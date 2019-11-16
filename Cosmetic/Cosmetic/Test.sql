select th."MaHieu", th."TenHieu", li."TenLoai", sp."TenSP", sp."DonGia" 
from "SanPham" sp join "ThuongHieu" th on sp."MaHieu" = th."MaHieu" join "Loai" li on sp."MaLoai" = li."MaLoai" 
order by li."TenLoai";