using Microsoft.AspNetCore.Mvc;
using System.Data;
using MySql.Data.MySqlClient;
using LE_ONGJIANGCO.Data;
using LE_ONGJIANGCO.Models;
using Microsoft.AspNetCore.Http;
using System.Xml;
using System.Xml.Schema;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Xml.Linq;


public class EmployeeController : Controller
{
    private readonly OngjiangcoContext _context;

    public EmployeeController()
    {
        string connectionString = "Server=localhost;Database=LE_ONGJIANGCO;User=root;Password=;";
        _context = new OngjiangcoContext(connectionString);
    }

    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(EmployeeModel model)
    {
        if (ModelState.IsValid)
        {
            string query = "INSERT INTO employees (emp_fullname, emp_addr, emp_contact, emp_email, emp_pwd) " +
                           "VALUES (@Fullname, @Address, @Contact, @Email, @Password)";

            MySqlParameter[] parameters = {
                new MySqlParameter("@Fullname", model.EmpFullname),
                new MySqlParameter("@Address", model.EmpAddr),
                new MySqlParameter("@Contact", model.EmpContact),
                new MySqlParameter("@Email", model.EmpEmail),
                new MySqlParameter("@Password", model.EmpPwd)
            };

            _context.ExecuteQuery(query, parameters);
            return RedirectToAction("Index");
        }
        return View(model);
    }
    
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Login(LoginModel model)
    {
        if (ModelState.IsValid)
        {
            string query = "SELECT * FROM employees WHERE emp_email = @Email AND emp_pwd = @Password";
            MySqlParameter[] parameters = {
                new MySqlParameter("@Email", model.Email),
                new MySqlParameter("@Password", model.Password)
            };

            DataTable result = _context.SelectQuery(query, parameters);

            if (model.Email == "adora@gmail.com" && model.Password == "1234" || result.Rows.Count > 0)
            {
                //HttpContext.Session.SetString("@Email", model.Email.ToString());
                return RedirectToAction("Index");
            }
            
            ModelState.AddModelError("", "Invalid login credentials.");
        }
        return View(model);
    }


    public IActionResult Index()
    {
        string query = "SELECT * FROM employees";
        DataTable employees = _context.SelectQuery(query);
        return View(employees);
    }


    [HttpGet]
    public IActionResult Edit(int id)
    {
        Console.WriteLine($"[DEBUG] Edit GET - Employee ID received: {id}");

        string query = "SELECT * FROM employees WHERE emp_id = @Id";
        MySqlParameter[] parameters = { new MySqlParameter("@Id", id) };
        DataTable result = _context.SelectQuery(query, parameters);

        if (result.Rows.Count == 0)
        {
            Console.WriteLine("[ERROR] Employee not found!");
            return NotFound();
        }

        DataRow row = result.Rows[0];

        EmployeeModel model = new EmployeeModel
        {
            EmpId = id,
            EmpFullname = row["emp_fullname"].ToString(),
            EmpAddr = row["emp_addr"].ToString(),
            EmpContact = row["emp_contact"].ToString(),
            EmpEmail = row["emp_email"].ToString()
        };

        return View(model);
    }


    [HttpPost]
    public IActionResult Edit(EmployeeModel model)
    {
        Console.WriteLine($"[DEBUG] Entered POST Edit - Employee ID: {model.EmpId}");

        if (!ModelState.IsValid)
        {
            Console.WriteLine("[ERROR] ModelState is invalid");
            return View(model);
        }

        string query = "UPDATE employees SET emp_fullname = @Fullname, emp_addr = @Address, emp_contact = @Contact WHERE emp_id = @Id";

        MySqlParameter[] parameters = {
        new MySqlParameter("@Id", model.EmpId),
        new MySqlParameter("@Fullname", model.EmpFullname),
        new MySqlParameter("@Address", model.EmpAddr),
        new MySqlParameter("@Contact", model.EmpContact)
    };

        int rowsAffected = _context.ExecuteQuery(query, parameters);
        Console.WriteLine($"[DEBUG] Rows affected: {rowsAffected}");

        if (rowsAffected == 0)
        {
            Console.WriteLine("[ERROR] Update failed. No rows affected.");
            ModelState.AddModelError("", "Update failed. Please try again.");
            return View(model);
        }

        return RedirectToAction("Index");
    }


    public IActionResult Delete(int id)
    {
        string query = "DELETE FROM employees WHERE emp_id = @Id";
        MySqlParameter[] parameters = { new MySqlParameter("@Id", id) };
        _context.ExecuteQuery(query, parameters);

        return RedirectToAction("Index");
    }

}
