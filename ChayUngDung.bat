@echo off
chcp 65001 >nul
title Quản Lý Ký Túc Xá - C# WinForms
echo ========================================================
echo   KHỞI CHẠY PHẦN MỀM QUẢN LÝ KÝ TÚC XÁ (.NET 4.8)
echo   Phân hệ 2: Sinh viên & Hợp đồng thuê phòng (Anh Thy)
echo ========================================================
echo.
echo Đang kiểm tra và biên dịch mã nguồn...
dotnet build QuanLyKyTucXa.sln
if %errorlevel% neq 0 (
    echo.
    echo [LỖI] Biên dịch thất bại! Vui lòng kiểm tra lại mã nguồn.
    pause
    exit /b %errorlevel%
)
echo.
echo [THÀNH CÔNG] Đang khởi chạy giao diện ứng dụng...
start "" "src\QuanLyKyTucXa\bin\Debug\QuanLyKyTucXa.exe"
exit /b 0
