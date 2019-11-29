using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cosmetic.Models;
using Cosmetic.Encrytions;
using OfficeOpenXml;
using System.Text; 

namespace WebOnline.Controllers
{
    public class KhachHangsController : Controller
    {
        private readonly MyPhamContext _context;

        public KhachHangsController(MyPhamContext context)
        {
            _context = context;
        }

        // GET: KhachHangs
        [Route("[controller]/[action]")]
        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.Get<NhanVien>("MaNv") == null)
            {
                return Redirect("/Admin/Login");
            }
            else
            {
                return View(await _context.KhachHang.ToListAsync());
            }
        }

        // GET: KhachHangs/Details/5
       [Route("[controller]/[action]")]
        public async Task<IActionResult> Details(string id)
        {
            if (HttpContext.Session.Get<NhanVien>("MaNv") == null)
            {
                return Redirect("/Admin/Login");
            }
            else
            {
                if (id == null)
                {
                    return NotFound();
                }

                var khachHang = await _context.KhachHang
                    .FirstOrDefaultAsync(m => m.MaKh == id);
                if (khachHang == null)
                {
                    return NotFound();
                }


                return View(khachHang);
            }
        }

        // GET: KhachHangs/Create
        [Route("[controller]/[action]")]
        public IActionResult Create()
        {
            if (HttpContext.Session.Get<NhanVien>("MaNv") == null)
            {
                return Redirect("/Admin/Login");
            }
            else
            {
                return View();
            }
        }

        // POST: KhachHangs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Route("[controller]/[action]")]
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaKh,MatKhau,HoTen,GioiTinh,NgaySinh,DiaChi,DienThoai,Email,HieuLuc")] KhachHang khachHang)
        {
            if (HttpContext.Session.Get<NhanVien>("MaNv") == null)
            {
                return Redirect("/Admin/Login");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    PasswordHasher passwordHasher = new PasswordHasher();
                    khachHang.MatKhau = passwordHasher.HashPassword(khachHang.MatKhau);
                    _context.Add(khachHang);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(khachHang);
            }
        }

        // GET: KhachHangs/Edit/5
        [Route("[controller]/[action]")]
        public async Task<IActionResult> Edit(string id)
        {
            if (HttpContext.Session.Get<NhanVien>("MaNv") == null)
            {
                return Redirect("/Admin/Login");
            }
            else
            {
                if (id == null)
                {
                    return NotFound();
                }

                var khachHang = await _context.KhachHang.FindAsync(id);
                if (khachHang == null)
                {
                    return NotFound();
                }
                return View(khachHang);
            }
        }

        // POST: KhachHangs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
       [Route("[controller]/[action]")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaKh,MatKhau,HoTen,GioiTinh,NgaySinh,DiaChi,DienThoai,Email,HieuLuc")] KhachHang khachHang)
        {
            if (HttpContext.Session.Get<NhanVien>("MaNv") == null)
            {
                return Redirect("/Admin/Login");
            }
            else
            {
                if (id != khachHang.MaKh)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        PasswordHasher passwordHasher = new PasswordHasher();
                        khachHang.MatKhau = passwordHasher.HashPassword(khachHang.MatKhau);
                        _context.Update(khachHang);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!KhachHangExists(khachHang.MaKh))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                    return RedirectToAction(nameof(Index));
                }
                return View(khachHang);
            }
        }

        // GET: KhachHangs/Delete/5
       [Route("[controller]/[action]")]
        public async Task<IActionResult> Delete(string id)
        {
            if (HttpContext.Session.Get<NhanVien>("MaNv") == null)
            {
                return Redirect("/Admin/Login");
            }
            else
            {
                if (id == null)
                {
                    return NotFound();
                }

                var khachHang = await _context.KhachHang
                    .FirstOrDefaultAsync(m => m.MaKh == id);
                if (khachHang == null)
                {
                    return NotFound();
                }

                return View(khachHang);
            }
        }

        // POST: KhachHangs/Delete/5
       [Route("[controller]/[action]")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (HttpContext.Session.Get<NhanVien>("MaNv") == null)
            {
                return Redirect("/Admin/Login");
            }
            else
            {
                var khachHang = await _context.KhachHang.FindAsync(id);
                _context.KhachHang.Remove(khachHang);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
        }

        private bool KhachHangExists(string id)
        {
            return _context.KhachHang.Any(e => e.MaKh == id);
        }
        [Route("[controller]/[action]")]
        public IActionResult AddnewKhachHang()
        {
            return View();
        }
        [Route("[controller]/[action]")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddnewKhachHang
([Bind("MaKh,MatKhau,HoTen,GioiTinh,NgaySinh,DiaChi,DienThoai,Email,HieuLuc")] KhachHang khachHang)
        {
            if (ModelState.IsValid)
            {
                PasswordHasher passwordHasher = new PasswordHasher();
                khachHang.MatKhau = passwordHasher.HashPassword(khachHang.MatKhau);
                _context.Add(khachHang);
                await _context.SaveChangesAsync();
                return RedirectToAction("../Home/Index");
            }
            return View(khachHang);
        }


        [Route("[controller]/[action]")]
        public IActionResult XuatExcel()
        {
            return Xuat("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
        }

        [Route("[controller]/[action]")]
        public IActionResult XuatDoc()
        {
            return Xuat("application/vnd.openxmlformats-officedocument.wordprocessingml.document");
        }
        [Route("[controller]/[action]")]
        public IActionResult XuatText()
        {
            return Xuat("text");
        }

        private FileStreamResult Xuat(string filetype)
        {
            var data = _context.KhachHang.ToList();

            var stream = new MemoryStream();

            using(var package = new ExcelPackage(stream))
            {
                var sheet = package.Workbook.Worksheets.Add("KhachHang");
                sheet.Cells[1,1].Value = "Họ tên";
                sheet.Cells[1,2].Value = "Email";
                sheet.Cells[1,3].Value = "Số điện thoại";
                sheet.Cells[1,4].Value = "Địa chỉ";
                int rowIdx = 2;
                foreach(var p in data)
                {
                    sheet.Cells[rowIdx, 1].Value = p.HoTen;
                    sheet.Cells[rowIdx, 2].Value = p.Email;
                    sheet.Cells[rowIdx, 3].Value = "+84" + p.DienThoai;
                    sheet.Cells[rowIdx, 4].Value = p.DiaChi;
                    ++rowIdx;
                }   
                package.Save();
            }

            stream.Position = 0;
            if (filetype.Equals("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"))
            {
                return new FileStreamResult(stream, filetype) 
                { 
                    FileDownloadName = "export.xlsx" 
                };
            }
            else if (filetype.Equals("application/vnd.openxmlformats-officedocument.wordprocessingml.document"))
            {
                return new FileStreamResult(stream, filetype) 
                { 
                    FileDownloadName = "export.docx"
                };
            }
            else 
            {
                return new FileStreamResult(stream, "text/plain") 
                { 
                    FileDownloadName = "export.txt"
                };
            }
        }
        private Stream GenerateStreamFromString(string s)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }
    }
}