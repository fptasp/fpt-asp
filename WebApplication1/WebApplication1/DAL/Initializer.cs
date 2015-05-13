using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplication1.Models;
using WebApplication1.Controllers;

namespace WebApplication1.DAL
{
    public class Initializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SachContext>
    {
        protected override void Seed(SachContext context)
        {
            var Sachs = new List<Sach>
            {
            new Sach{MaSach=1,MaLoai=1,Tensach="SachA",Tomtat="a",MaTG=1,MaNXB=1},
            new Sach{MaSach=2,MaLoai=1,Tensach="SachB",Tomtat="b",MaTG=1,MaNXB=1},
            new Sach{MaSach=3,MaLoai=1,Tensach="SachC",Tomtat="c",MaTG=1,MaNXB=2},
            new Sach{MaSach=4,MaLoai=2,Tensach="SachD",Tomtat="d",MaTG=2,MaNXB=2},
            new Sach{MaSach=5,MaLoai=2,Tensach="SachE",Tomtat="e",MaTG=2,MaNXB=3},
            new Sach{MaSach=6,MaLoai=2,Tensach="SachF",Tomtat="f",MaTG=2,MaNXB=3}
            };

            Sachs.ForEach(s => context.Sachs.Add(s));
            context.SaveChanges();
            var Tacgias = new List<Tacgia>
            {
            new Tacgia{MaTG=1,Tentacgia="tacgiaA",Diachi="diachiA",SDT="sdtA",Email="tacgiaA@gmail.com"},
            new Tacgia{MaTG=2,Tentacgia="tacgiaB",Diachi="diachiB",SDT="sdtB",Email="tacgiaB@gmail.com"}
            };
            Tacgias.ForEach(s => context.Tacgias.Add(s));
            context.SaveChanges();

            var LinkTacgias = new List<LinkTacgia>
            {
            new LinkTacgia{MaTG=1},
            new LinkTacgia{MaTG=2}
            };
            LinkTacgias.ForEach(s => context.LinkTacgias.Add(s));
            context.SaveChanges();

            var NhaXBs = new List<NhaXB>
            {
            new NhaXB{MaNXB=1,TenNXB="nhaxuatbanA",Diachi="diachiA",SDT="sdtA",Email="nxbA@gmail.com"},
            new NhaXB{MaNXB=2,TenNXB="nhaxuatbanB",Diachi="diachiB",SDT="sdtB",Email="nxbB@gmail.com"}
            };
            NhaXBs.ForEach(s => context.NhaXBs.Add(s));
            context.SaveChanges();

            var LinkNhaXBs = new List<LinkNhaXB>
            {
            new LinkNhaXB{MaNXB=1},
            new LinkNhaXB{MaNXB=2},
            new LinkNhaXB{MaNXB=3}
            };
            LinkNhaXBs.ForEach(s => context.LinkNhaXBs.Add(s));
            context.SaveChanges();

            var LoaiSachs = new List<LoaiSach>
            {
            new LoaiSach{MaLoai=1,Tenloai="Dungtt"},
            new LoaiSach{MaLoai=2,Tenloai="Express"}
            };
            LoaiSachs.ForEach(s => context.LoaiSachs.Add(s));
            context.SaveChanges();

            var LinkLoaiSachs = new List<LinkLoaiSach>
            {
            new LinkLoaiSach{MaLoai=1},
            new LinkLoaiSach{MaLoai=2}
            };
            LinkLoaiSachs.ForEach(s => context.LinkLoaiSachs.Add(s));
            context.SaveChanges();

        }
    }
}