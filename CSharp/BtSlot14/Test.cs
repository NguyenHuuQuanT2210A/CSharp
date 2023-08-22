using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.BtSlot14
{
    public class Test
    {
        static void Main2(string[] args)
        {
            Functions cn = new Functions();

            int luaChon;

            do
            {
                Console.WriteLine("Chương trình quản lý sinh viên");
                Console.WriteLine("1. Thêm sinh viên");
                Console.WriteLine("2. Cập nhật sinh viên");
                Console.WriteLine("3. Xóa sinh viên");
                Console.WriteLine("4. Tìm kiếm sinh viên");
                Console.WriteLine("5. Sắp xếp sinh viên theo điểm trung bình");
                Console.WriteLine("6. Sắp xếp sinh viên theo tên");
                Console.WriteLine("7. Sắp xếp sinh viên theo ID");
                Console.WriteLine("8. Hiển thị danh sách sinh viên");
                Console.WriteLine("0. Thoát chương trình");

                Console.WriteLine("Nhập lựa chọn của bạn: ");
                luaChon = int.Parse(Console.ReadLine());

                switch (luaChon)
                {
                    case 1:
                        cn.themSinhVien();
                        break;
                    case 2:
                        cn.capNhatSinhVien();
                        break;
                    case 3:
                        cn.xoaSinhVien();
                        break;
                    case 4:
                        cn.timKiemSinhVien();
                        break;
                    case 5:
                        cn.sapXepTheoDiemTrungBinh();
                        break;
                    case 6:
                        cn.sapXepTheoTen();
                        break;
                    case 7:
                        cn.sapXepTheoID();
                        break;
                    case 8:
                        cn.hienThiDanhSach();
                        break;
                    case 0:
                        Console.WriteLine("Cảm ơn bạn đã sử dụng chương trình!");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ! Vui lòng nhập lại!");
                        break;
                }

            } while (luaChon != 0);

        }
    }
}
