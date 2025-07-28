using Microsoft.EntityFrameworkCore;
using WinFormsWorkApp1.Helpers;
using WinFormsWorkApp1.Models;

namespace WinFormsWorkApp1
{
    public static class DataSeeder
    {
        public static void SeedData(NursingHomeDbContext context)
        {        // Ensure database is created
            context.Database.EnsureCreated();

            // Check if base tables have meaningful data (more than 0 employees)
            bool baseTablesPopulated = context.Employees.Any() && context.Employees.Count() >= 5;

            if (!baseTablesPopulated)
            {
                Console.WriteLine("开始填充基础表数据...");// Seed base tables (no dependencies) - save after each to identify issues
                try
                {
                    SeedEmployees(context);
                    context.SaveChanges();
                    Console.WriteLine("Employees seeded successfully");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error seeding Employees: {ex.Message}");
                    throw;
                }

                try
                {
                    SeedResidents(context);
                    context.SaveChanges();
                    Console.WriteLine("Residents seeded successfully");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error seeding Residents: {ex.Message}");
                    throw;
                }

                try
                {
                    SeedBeds(context);
                    context.SaveChanges();
                    Console.WriteLine("Beds seeded successfully");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error seeding Beds: {ex.Message}");
                    throw;
                }

                try
                {
                    SeedItems(context);
                    context.SaveChanges();
                    Console.WriteLine("Items seeded successfully");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error seeding Items: {ex.Message}");
                    throw;
                }

                try
                {
                    SeedMedications(context);
                    context.SaveChanges();
                    Console.WriteLine("Medications seeded successfully");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error seeding Medications: {ex.Message}");
                    throw;
                }

                try
                {
                    SeedCarePackages(context);
                    context.SaveChanges();
                    Console.WriteLine("CarePackages seeded successfully");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error seeding CarePackages: {ex.Message}");
                    throw;
                }

                try
                {
                    SeedFeeTypes(context);
                    context.SaveChanges();
                    Console.WriteLine("FeeTypes seeded successfully");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error seeding FeeTypes: {ex.Message}");
                    throw;
                }

                try
                {
                    SeedConsultants(context);
                    context.SaveChanges();
                    Console.WriteLine("Consultants seeded successfully");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error seeding Consultants: {ex.Message}");
                    throw;
                }

                try
                {
                    SeedFacilities(context);
                    context.SaveChanges();
                    Console.WriteLine("Facilities seeded successfully");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error seeding Facilities: {ex.Message}");
                    throw;
                }

                try
                {
                    SeedWarehouses(context);
                    context.SaveChanges();
                    Console.WriteLine("Warehouses seeded successfully");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error seeding Warehouses: {ex.Message}");
                    throw;
                }
                Console.WriteLine("基础表数据填充完成！");
            }

            // Always attempt to seed dependent tables (regardless of whether base tables existed)
            Console.WriteLine("开始填充关联表数据...");

            // Seed tables with foreign key dependencies - save after each to identify issues
            try
            {
                if (!context.FeeRecords.Any())
                {
                    SeedFeeRecords(context);
                    context.SaveChanges();
                    Console.WriteLine("FeeRecords seeded successfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error seeding FeeRecords: {ex.Message}");
                Console.WriteLine($"Inner exception: {ex.InnerException?.Message}");
            }

            try
            {
                if (!context.OutingRecords.Any())
                {
                    SeedOutingRecords(context);
                    context.SaveChanges();
                    Console.WriteLine("OutingRecords seeded successfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error seeding OutingRecords: {ex.Message}");
            }

            try
            {
                if (!context.PaymentRecords.Any())
                {
                    SeedPaymentRecords(context);
                    context.SaveChanges();
                    Console.WriteLine("PaymentRecords seeded successfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error seeding PaymentRecords: {ex.Message}");
            }

            try
            {
                if (!context.LeaveRecords.Any())
                {
                    SeedLeaveRecords(context);
                    context.SaveChanges();
                    Console.WriteLine("LeaveRecords seeded successfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error seeding LeaveRecords: {ex.Message}");
            }

            try
            {
                if (!context.Reservations.Any())
                {
                    SeedReservations(context);
                    context.SaveChanges();
                    Console.WriteLine("Reservations seeded successfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error seeding Reservations: {ex.Message}");
            }

            try
            {
                if (!context.MealRecords.Any())
                {
                    SeedMealRecords(context);
                    context.SaveChanges();
                    Console.WriteLine("MealRecords seeded successfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error seeding MealRecords: {ex.Message}");
            }

            try
            {
                if (!context.CareRecords.Any())
                {
                    SeedCareRecords(context);
                    context.SaveChanges();
                    Console.WriteLine("CareRecords seeded successfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error seeding CareRecords: {ex.Message}");
            }

            try
            {
                if (!context.HealthRecords.Any())
                {
                    SeedHealthRecords(context);
                    context.SaveChanges();
                    Console.WriteLine("HealthRecords seeded successfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error seeding HealthRecords: {ex.Message}");
            }

            try
            {
                if (!context.MedicationRecords.Any())
                {
                    SeedMedicationRecords(context);
                    context.SaveChanges();
                    Console.WriteLine("MedicationRecords seeded successfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error seeding MedicationRecords: {ex.Message}");
            }

            try
            {
                if (!context.MedicalMonitorings.Any())
                {
                    SeedMedicalMonitorings(context);
                    context.SaveChanges();
                    Console.WriteLine("MedicalMonitorings seeded successfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error seeding MedicalMonitorings: {ex.Message}");
            }

            try
            {
                if (!context.AttendanceRecords.Any())
                {
                    SeedAttendanceRecords(context);
                    context.SaveChanges();
                    Console.WriteLine("AttendanceRecords seeded successfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error seeding AttendanceRecords: {ex.Message}");
            }

            try
            {
                if (!context.Inventories.Any())
                {
                    SeedInventories(context);
                    context.SaveChanges();
                    Console.WriteLine("Inventories seeded successfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error seeding Inventories: {ex.Message}");
            }

            try
            {
                if (!context.InventoryTransactions.Any())
                {
                    SeedInventoryTransactions(context);
                    context.SaveChanges();
                    Console.WriteLine("InventoryTransactions seeded successfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error seeding InventoryTransactions: {ex.Message}");
            }

            Console.WriteLine("数据库数据填充完成！");
        }
        private static void SeedEmployees(NursingHomeDbContext context)
        {
            // 员工编号格式: 部门代码(2位)+员工级别(2位)+员工序号(4位)+特征编号(2位) = 10位
            var employees = new[]
            {
    new Employee
    {
        Name = "张美玲",
        IdCard = "0101000101", // 护理部(01)+主任级(01)+序号(0001)+特征(01)
        Username = "zhang001",
        Password = "123456",
        Gender = "女",
        Age = 35,
        Phone = "139-0001-2345",
        Address = "北京市朝阳区建国路1号",
        Position = "护理主任",
        Department = "护理部",
        HireDate = DateTime.Now.AddYears(-5),
        CreateTime = DateTime.Now
    },
    new Employee
    {
        Name = "李志强",
        IdCard = "0102000201", // 护理部(01)+护理师(02)+序号(0002)+特征(01)
        Username = "li002",
        Password = "123456",
        Gender = "男",
        Age = 28,
        Phone = "138-0002-3456",
        Address = "北京市海淀区中关村大街20号",
        Position = "护理师",
        Department = "护理部",
        HireDate = DateTime.Now.AddYears(-3),
        CreateTime = DateTime.Now
    },
    new Employee
    {
        Name = "王淑芬",
        IdCard = "0201000301", // 康复科(02)+康复师(01)+序号(0003)+特征(01)
        Username = "wang003",
        Password = "123456",
        Gender = "女",
        Age = 32,
        Phone = "137-0003-4567",
        Address = "北京市东城区王府井大街30号",
        Position = "康复师",
        Department = "康复科",
        HireDate = DateTime.Now.AddYears(-2),
        CreateTime = DateTime.Now
    },
    new Employee
    {
        Name = "陈建国",
        IdCard = "0301000401", // 营养部(03)+营养师(01)+序号(0004)+特征(01)
        Username = "chen004",
        Password = "123456",
        Gender = "男",
        Age = 40,
        Phone = "136-0004-5678",
        Address = "北京市西城区金融街40号",
        Position = "营养师",
        Department = "营养部",
        HireDate = DateTime.Now.AddYears(-4),
        CreateTime = DateTime.Now
    },
    new Employee
    {
        Name = "林小华",
        IdCard = "0401000501", // 社工部(04)+社工师(01)+序号(0005)+特征(01)
        Username = "lin005",
        Password = "123456",
        Gender = "女",
        Age = 29,
        Phone = "135-0005-6789",
        Address = "北京市丰台区南三环西路50号",
        Position = "社工师",
        Department = "社工部",
        HireDate = DateTime.Now.AddYears(-1),
        CreateTime = DateTime.Now
    },
    new Employee
    {
        Name = "黄雅慧",
        IdCard = "0501000601", // 行政部(05)+行政员(01)+序号(0006)+特征(01)
        Username = "huang006",
        Password = "123456",
        Gender = "女",
        Age = 26,
        Phone = "134-0006-7890",
        Address = "北京市石景山区石景山路60号",
        Position = "行政人员",
        Department = "行政部",
        HireDate = DateTime.Now.AddMonths(-6),
        CreateTime = DateTime.Now
    }
};

            context.Employees.AddRange(employees);
        }
        private static void SeedResidents(NursingHomeDbContext context)
        {
            // 老年人编号格式: 入院年份(4位)+老年人序号(4位)+特征编号(2位) = 10位
            var residents = new[]
            {    new Resident
    {
        Name = "刘奶奶",
        IdCard = "A123456789",
        Gender = "女",
        Age = 85,
        Phone = "139-1111-2222",
        Address = "北京市朝阳区望京街道",
        EmergencyContact = "女儿刘小美",
        EmergencyPhone = "139-1111-2222",
        MedicalHistory = "高血压、糖尿病",
        CheckInDate = new DateTime(2020, 3, 15),
        Status = "在住",
        BedId = 1
    },
    new Resident
    {
        Name = "陈爷爷",
        IdCard = "B234567890",
        Gender = "男",
        Age = 78,
        Phone = "138-3333-4444",
        Address = "北京市海淀区中关村",
        EmergencyContact = "儿子陈大明",
        EmergencyPhone = "138-3333-4444",
        MedicalHistory = "中风后遗症",
        CheckInDate = new DateTime(2021, 1, 10),
        Status = "在住",
        BedId = 2
    },
    new Resident
    {
        Name = "王奶奶",
        IdCard = "C345678901",
        Gender = "女",
        Age = 82,
        Phone = "137-5555-6666",
        Address = "北京市东城区前门",
        EmergencyContact = "女儿王小玉",
        EmergencyPhone = "137-5555-6666",
        MedicalHistory = "阿尔茨海默病",
        CheckInDate = new DateTime(2021, 6, 20),
        Status = "在住",
        BedId = 3
    },
    new Resident
    {
        Name = "李老先生",
        IdCard = "D456789012",
        Gender = "男",
        Age = 75,
        Phone = "136-7777-8888",
        Address = "北京市西城区金融街",
        EmergencyContact = "太太李太太",
        EmergencyPhone = "136-7777-8888",
        MedicalHistory = "帕金森病",
        CheckInDate = new DateTime(2022, 2, 14),
        Status = "在住",
        BedId = 4
    },
    new Resident
    {
        Name = "张阿姨",
        IdCard = "E567890123",
        Gender = "女",
        Age = 70,
        Phone = "135-9999-0000",
        Address = "北京市丰台区方庄",
        EmergencyContact = "儿子张大伟",
        EmergencyPhone = "135-9999-0000",
        MedicalHistory = "关节炎",
        CheckInDate = new DateTime(2022, 8, 5),
        Status = "在住",
        BedId = 5
    },
    new Resident
    {
        Name = "赵伯伯",
        IdCard = "F678901234",
        Gender = "男",
        Age = 80,
        Phone = "134-1111-3333",
        Address = "北京市石景山区八角",
        EmergencyContact = "女儿赵小慧",
        EmergencyPhone = "134-1111-3333",
        MedicalHistory = "心脏病",
        CheckInDate = new DateTime(2023, 4, 12),
        Status = "在住",
        BedId = 6
    }
};

            context.Residents.AddRange(residents);
        }
        private static void SeedBeds(NursingHomeDbContext context)
        {
            // 床位编号格式: 床位房间号(3位)+房间内床位序号(3位)+床位购买年份(2位)+特征编号(2位) = 10位
            var beds = new[]
            {
    new Bed
    {
        BedNumber = "1010012001", // 101房间(101)+床位001+购买年份20+特征01
        RoomNumber = "101",
        Status = "已入住",
        MonthlyRate = 25000,
        Facilities = "卫浴、空调、电话"
    },
    new Bed
    {
        BedNumber = "1010022001", // 101房间(101)+床位002+购买年份20+特征01
        RoomNumber = "101",
        Status = "已入住",
        MonthlyRate = 25000,
        Facilities = "卫浴、空调、电话"
    },
    new Bed
    {
        BedNumber = "1020012101", // 102房间(102)+床位001+购买年份21+特征01
        RoomNumber = "102",
        Status = "已入住",
        MonthlyRate = 25000,
        Facilities = "卫浴、空调、电话"
    },
    new Bed
    {
        BedNumber = "1020022201", // 102房间(102)+床位002+购买年份22+特征01
        RoomNumber = "102",
        Status = "已入住",
        MonthlyRate = 25000,
        Facilities = "卫浴、空调、电话"
    },
    new Bed
    {
        BedNumber = "1030012201", // 103房间(103)+床位001+购买年份22+特征01
        RoomNumber = "103",
        Status = "已入住",
        MonthlyRate = 25000,
        Facilities = "卫浴、空调、电话"
    },
    new Bed
    {
        BedNumber = "1030022301", // 103房间(103)+床位002+购买年份23+特征01
        RoomNumber = "103",
        Status = "已入住",
        MonthlyRate = 25000,
        Facilities = "卫浴、空调、电话"
    }
};

            context.Beds.AddRange(beds);
        }
        private static void SeedItems(NursingHomeDbContext context)
        {
            // 物品编号格式: 物品类别(4位)+物品序号(4位)+特征编号(2位) = 10位
            var items = new[]
            {
    new Item
    {
        Name = "轮椅",
        Category = "康复器材",
        Specification = "标准型轮椅",
        Unit = "台",
        PurchasePrice = 5000
    },
    new Item
    {
        Name = "助行器",
        Category = "康复器材",
        Specification = "四脚助行器",
        Unit = "个",
        PurchasePrice = 1500
    },
    new Item
    {
        Name = "血压计",
        Category = "医疗器材",
        Specification = "电子血压计",
        Unit = "台",
        PurchasePrice = 3000
    },
    new Item
    {
        Name = "体温计",
        Category = "医疗器材",
        Specification = "额温枪",
        Unit = "支",
        PurchasePrice = 800
    },
    new Item
    {
        Name = "病床",
        Category = "家具",
        Specification = "电动病床",
        Unit = "张",
        PurchasePrice = 50000
    },
    new Item
    {
        Name = "床头柜",
        Category = "家具",
        Specification = "三层床头柜",
        Unit = "个",
        PurchasePrice = 3000
    }
};

            context.Items.AddRange(items);
        }
        private static void SeedMedications(NursingHomeDbContext context)
        {
            // 药物编号格式: 药物类别(4位)+药物序号(4位)+特征编号(2位) = 10位
            var medications = new[]
            {
    new Medication
    {
        MedicationName = "降压药",
        MedicationType = "心血管用药",
        Specification = "5mg片剂"
    },
    new Medication
    {
        MedicationName = "降血糖药",
        MedicationType = "内分泌用药",
        Specification = "500mg片剂"
    },
    new Medication
    {
        MedicationName = "止痛药",
        MedicationType = "止痛消炎药",
        Specification = "200mg片剂"
    },
    new Medication
    {
        MedicationName = "安眠药",
        MedicationType = "精神科用药",
        Specification = "2mg片剂"
    },
    new Medication
    {
        MedicationName = "维生素D",
        MedicationType = "营养补充剂",
        Specification = "1000IU软胶囊"
    }
};

            context.Medications.AddRange(medications);
        }
        private static void SeedCarePackages(NursingHomeDbContext context)
        {
            var carePackages = new[]
            {
    new CarePackage
    {
        PackageName = "基础护理套餐",
        ServiceItems = "日常生活协助、用餐协助、个人卫生护理",
        CareLevel = "轻度护理"
    },
    new CarePackage
    {
        PackageName = "进阶护理套餐",
        ServiceItems = "基础护理+康复服务、健康监测、家属咨询",
        CareLevel = "中度护理"
    },
    new CarePackage
    {
        PackageName = "全方位护理套餐",
        ServiceItems = "进阶护理+24小时护理、医疗服务、紧急处理",
        CareLevel = "重度护理"
    },
    new CarePackage
    {
        PackageName = "康复专项套餐",
        ServiceItems = "物理治疗、职业治疗、语言治疗、运动指导",
        CareLevel = "中度护理"
    },
    new CarePackage
    {
        PackageName = "失智专项套餐",
        ServiceItems = "认知训练、行为管理、安全护理、家属支持",
        CareLevel = "重度护理"
    }
};

            context.CarePackages.AddRange(carePackages);
        }
        private static void SeedFeeTypes(NursingHomeDbContext context)
        {
            var feeTypes = new[]
            {
    new FeeType
    {
        TypeName = "月费",
        StandardPrice = 25000
    },
    new FeeType
    {
        TypeName = "护理费",
        StandardPrice = 8000
    },
    new FeeType
    {
        TypeName = "康复费",
        StandardPrice = 3000
    },
    new FeeType
    {
        TypeName = "餐费",
        StandardPrice = 5000
    },
    new FeeType
    {
        TypeName = "医疗费",
        StandardPrice = 2000
    }
};

            context.FeeTypes.AddRange(feeTypes);
        }
        private static void SeedFeeRecords(NursingHomeDbContext context)
        {
            // Get actual IDs from database instead of using hardcoded values
            var residents = context.Residents.OrderBy(r => r.Id).Take(6).ToList();
            var feeTypes = context.FeeTypes.OrderBy(ft => ft.Id).Take(12).ToList();

            if (!residents.Any() || !feeTypes.Any())
            {
                Console.WriteLine("Cannot seed FeeRecords: No residents or fee types found in database");
                return;
            }

            // 收费记录编号格式: 收费日期(6位)+老年人序号(4位)+特征编号(2位) = 12位
            var feeRecords = new[]
            {
        new FeeRecord
        {
            ResidentId = residents[0].Id,
            FeeTypeId = feeTypes[0].Id,
            Amount = 25000,
            BillingDate = new DateTime(2024, 1, 1),
            DueDate = new DateTime(2024, 1, 31),            Status = "已缴费",
            Remarks = "一月份住宿费用"
        },
        new FeeRecord
        {
            ResidentId = residents[1].Id,
            FeeTypeId = feeTypes[0].Id,
            Amount = 25000,
            BillingDate = new DateTime(2024, 1, 1),
            DueDate = new DateTime(2024, 1, 31),
            Status = "已缴费",
            Remarks = "一月份住宿费用"
        },
        new FeeRecord
        {
            ResidentId = residents[2].Id,
            FeeTypeId = feeTypes[1].Id,
            Amount = 8000,
            BillingDate = new DateTime(2024, 1, 1),
            DueDate = new DateTime(2024, 1, 31),
            Status = "已缴费",
            Remarks = "一月份护理费用"
        },
        new FeeRecord
        {
            ResidentId = residents[3].Id,
            FeeTypeId = feeTypes[2].Id,
            Amount = 3000,
            BillingDate = new DateTime(2024, 1, 1),
            DueDate = new DateTime(2024, 1, 31),
            Status = "未缴费",
            Remarks = "一月份餐饮费用"
        },
        new FeeRecord
        {
            ResidentId = residents[4].Id,
            FeeTypeId = feeTypes[3].Id,
            Amount = 5000,
            BillingDate = new DateTime(2024, 1, 1),
            DueDate = new DateTime(2024, 1, 31),
            Status = "已缴费",
            Remarks = "一月份医疗费用"
        }
    };

            context.FeeRecords.AddRange(feeRecords);
        }

        private static void SeedOutingRecords(NursingHomeDbContext context)
        {
            // 外出编号格式: 外出日期(6位)+老年人序号(4位)+特征编号(2位) = 12位
            var outingRecords = new[]
            {
    new OutingRecord
    {
        ResidentId = 1,
        OutTime = new DateTime(2024, 1, 15, 9, 0, 0),
        ReturnTime = new DateTime(2024, 1, 15, 16, 30, 0),
        Status = "已返回"
    },
    new OutingRecord
    {
        ResidentId = 2,
        OutTime = new DateTime(2024, 1, 20, 10, 0, 0),
        ReturnTime = new DateTime(2024, 1, 20, 15, 0, 0),
        Status = "已返回"
    },
    new OutingRecord
    {
        ResidentId = 3,
        OutTime = new DateTime(2024, 1, 25, 11, 0, 0),
        ReturnTime = new DateTime(2024, 1, 25, 18, 0, 0),
        Status = "已返回"
    },
    new OutingRecord
    {
        ResidentId = 4,
        OutTime = new DateTime(2024, 1, 30, 14, 0, 0),
        ReturnTime = new DateTime(2024, 1, 30, 17, 30, 0),
        Status = "已返回"
    },
    new OutingRecord
    {
        ResidentId = 5,
        OutTime = new DateTime(2024, 2, 5, 13, 0, 0),
        ReturnTime = new DateTime(2024, 2, 5, 16, 0, 0),
        Status = "已返回"
    }
};

            context.OutingRecords.AddRange(outingRecords);
        }
        private static void SeedPaymentRecords(NursingHomeDbContext context)
        {
            // 缴费编号格式: 缴费日期(6位)+老年人序号(4位)+特征编号(2位) = 12位
            var paymentRecords = new[]
            {
    new PaymentRecord
    {
        PaymentDate = new DateTime(2024, 1, 1),
        PaymentMethod = "转账",
        FeeRecordId = 1
    },
    new PaymentRecord
    {
        PaymentDate = new DateTime(2024, 1, 1),
        PaymentMethod = "现金",
        FeeRecordId = 2
    },
    new PaymentRecord
    {
        PaymentDate = new DateTime(2024, 1, 1),
        PaymentMethod = "信用卡",
        FeeRecordId = 3
    },
    new PaymentRecord
    {
        PaymentDate = new DateTime(2024, 1, 1),
        PaymentMethod = "转账",
        FeeRecordId = 4
    },
    new PaymentRecord
    {
        PaymentDate = new DateTime(2024, 1, 1),
        PaymentMethod = "现金",
        FeeRecordId = 5
    }
};

            context.PaymentRecords.AddRange(paymentRecords);
        }
        private static void SeedLeaveRecords(NursingHomeDbContext context)
        {
            // 离职编号格式: 离职序号(4位)+员工序号(4位)+特征编号(2位) = 10位
            var leaveRecords = new[]
            {
    new LeaveRecord
    {
        EmployeeId = 1,
        LeaveType = "年假",
        StartDate = new DateTime(2024, 2, 1),
        EndDate = new DateTime(2024, 2, 3),
        Reason = "家庭事务"
    },
    new LeaveRecord
    {
        EmployeeId = 2,
        LeaveType = "病假",
        StartDate = new DateTime(2024, 1, 15),
        EndDate = new DateTime(2024, 1, 16),
        Reason = "感冒就医"
    },
    new LeaveRecord
    {
        EmployeeId = 3,
        LeaveType = "事假",
        StartDate = new DateTime(2024, 1, 20),
        EndDate = new DateTime(2024, 1, 20),
        Reason = "个人事务"
    },
    new LeaveRecord
    {
        EmployeeId = 4,
        LeaveType = "年假",
        StartDate = new DateTime(2024, 3, 10),
        EndDate = new DateTime(2024, 3, 14),
        Reason = "休假旅游"
    },
    new LeaveRecord
    {
        EmployeeId = 5,
        LeaveType = "特休",
        StartDate = new DateTime(2024, 2, 20),
        EndDate = new DateTime(2024, 2, 21),
        Reason = "家庭聚会"
    }
};

            context.LeaveRecords.AddRange(leaveRecords);
        }
        private static void SeedConsultants(NursingHomeDbContext context)
        {
            var consultants = new[]
            {
    new Consultant
    {
        Name = "陈大明",
        Phone = "139-2345-6789",
        Gender = "男",
        Age = 45,
        Address = "北京市朝阳区建国路100号",
        ContactPerson = "陈小明",
        ContactPhone = "139-2345-6790",
        Notes = "咨询长期护理服务"
    },
    new Consultant
    {
        Name = "李美华",
        Phone = "138-4444-5555",
        Gender = "女",
        Age = 52,
        Address = "上海市浦东新区陆家嘴环路200号",
        ContactPerson = "李大华",
        ContactPhone = "138-4444-5556",
        Notes = "为母亲咨询入住事宜"
    },
    new Consultant
    {
        Name = "王志强",
        Phone = "137-6666-7777",
        Gender = "男",
        Age = 38,
        Address = "广州市天河区珠江新城中央路300号",
        ContactPerson = "王美丽",
        ContactPhone = "137-6666-7778",
        Notes = "咨询康复服务"
    },
    new Consultant
    {
        Name = "张淑芬",
        Phone = "136-8888-9999",
        Gender = "女",
        Age = 60,
        Address = "深圳市南山区科技园南路400号",
        ContactPerson = "张建国",
        ContactPhone = "136-8888-9900",
        Notes = "自主咨询入住"
    },
    new Consultant
    {
        Name = "林建宏",
        Phone = "135-1111-2222",
        Gender = "男",
        Age = 43,
        Address = "杭州市西湖区文三路500号",
        ContactPerson = "林丽花",
        ContactPhone = "135-1111-2223",
        Notes = "为父亲寻找适合的养老院"
    }
};

            context.Consultants.AddRange(consultants);
        }
        private static void SeedFacilities(NursingHomeDbContext context)
        {
            var facilities = new[]
            {
    new Facility
    {
        Name = "康复中心",
        Category = "康复设施",
        Location = "北京市朝阳区",
        Description = "提供物理治疗和康复服务",
        PurchaseDate = new DateTime(2020, 1, 15),
        PurchasePrice = 500000,
        Manufacturer = "康复设备公司",
        Model = "RH-2020",
        Status = "正常"
    },
    new Facility
    {
        Name = "医疗站",
        Category = "医疗设施",
        Location = "北京市海淀区",
        Description = "提供基本医疗服务和急救设备",
        PurchaseDate = new DateTime(2019, 6, 20),
        PurchasePrice = 800000,
        Manufacturer = "医疗设备公司",
        Model = "MD-2019",
        Status = "正常"
    },
    new Facility
    {
        Name = "活动中心",
        Category = "娱乐设施",
        Location = "北京市东城区",
        Description = "提供社交活动和娱乐设施",
        PurchaseDate = new DateTime(2021, 3, 10),
        PurchasePrice = 300000,
        Manufacturer = "活动设备公司",
        Model = "AC-2021",
        Status = "正常"
    },
    new Facility
    {
        Name = "餐厅设备",
        Category = "生活设施",
        Location = "北京市西城区",
        Description = "餐厅厨房和用餐设备",
        PurchaseDate = new DateTime(2020, 8, 25),
        PurchasePrice = 400000,
        Manufacturer = "餐饮设备公司",
        Model = "KT-2020",
        Status = "正常"
    },
    new Facility
    {
        Name = "洗衣设备",
        Category = "生活设施",
        Location = "北京市丰台区",
        Description = "洗衣房设备和烘干设备",
        PurchaseDate = new DateTime(2021, 11, 5),
        PurchasePrice = 150000,
        Manufacturer = "洗衣设备公司",
        Model = "WS-2021",
        Status = "正常"
    }
};

            context.Facilities.AddRange(facilities);
        }
        private static void SeedWarehouses(NursingHomeDbContext context)
        {
            var warehouses = new[]
            {
    new Warehouse
    {
        Name = "药品库房",
        Location = "北京市朝阳区",
        Manager = "李药师",
        ContactPhone = "010-5678-9012",
        Category = "医疗用品仓",
        Description = "储存各类药品和医疗用品",
        Area = 50.5m,
        Capacity = 1000,
        Status = "正常使用"
    },
    new Warehouse
    {
        Name = "器材库房",
        Location = "北京市海淀区",
        Manager = "王管理员",
        ContactPhone = "010-6789-0123",
        Category = "设备器材仓",
        Description = "储存康复器材和医疗设备",
        Area = 80.0m,
        Capacity = 500,
        Status = "正常使用"
    },
    new Warehouse
    {
        Name = "生活用品仓",
        Location = "北京市东城区",
        Manager = "张仓管",
        ContactPhone = "010-7890-1234",
        Category = "生活用品仓",
        Description = "储存日常生活用品和清洁用品",
        Area = 60.0m,
        Capacity = 800,
        Status = "正常使用"
    },
    new Warehouse
    {
        Name = "食品仓库",
        Location = "北京市西城区",
        Manager = "刘主管",
        ContactPhone = "010-8901-2345",
        Category = "食品仓",
        Description = "储存各类食品和营养补充品",
        Area = 40.0m,
        Capacity = 600,
        Status = "正常使用"
    },
    new Warehouse
    {
        Name = "备用仓库",
        Location = "北京市丰台区",
        Manager = "陈助理",
        ContactPhone = "010-9012-3456",
        Category = "综合仓库",
        Description = "备用储存空间",
        Area = 30.0m,
        Capacity = 400,
        Status = "正常使用"
    }
};

            context.Warehouses.AddRange(warehouses);
        }
        private static void SeedReservations(NursingHomeDbContext context)
        {
            var reservations = new[]
            {
    new Reservation
    {
        ConsultantId = 1,
        BedId = 7,  // 使用尚未入住的床位
        ReservationDate = new DateTime(2024, 1, 5),
        PreferredMoveInDate = new DateTime(2024, 2, 1),
        Status = "已确认",
        ServiceType = "长期护理",
        EstimatedCost = 30000,
        Requirements = "需要糖尿病护理",
        Notes = "家属希望安排在一楼"
    },
    new Reservation
    {
        ConsultantId = 2,
        BedId = 8,
        ReservationDate = new DateTime(2024, 1, 10),
        PreferredMoveInDate = new DateTime(2024, 3, 1),
        Status = "待确认",
        ServiceType = "康复护理",
        EstimatedCost = 35000,
        Requirements = "需要物理治疗",
        Notes = "中风康复患者"
    },
    new Reservation
    {
        ConsultantId = 3,
        BedId = null,  // 尚未分配床位
        ReservationDate = new DateTime(2024, 1, 15),
        PreferredMoveInDate = new DateTime(2024, 4, 1),
        Status = "待确认",
        ServiceType = "基础护理",
        EstimatedCost = 25000,
        Requirements = "无特殊需求",
        Notes = "等待床位安排"
    },
    new Reservation
    {
        ConsultantId = 4,
        BedId = 9,
        ReservationDate = new DateTime(2024, 1, 20),
        PreferredMoveInDate = new DateTime(2024, 2, 15),
        Status = "已确认",
        ServiceType = "失智护理",
        EstimatedCost = 40000,
        Requirements = "需要专业失智护理",
        Notes = "中度阿尔茨海默病患者"
    },
    new Reservation
    {
        ConsultantId = 5,
        BedId = 10,
        ReservationDate = new DateTime(2024, 1, 25),
        PreferredMoveInDate = new DateTime(2024, 3, 15),
        Status = "已取消",
        ServiceType = "长期护理",
        EstimatedCost = 28000,
        Requirements = "家庭护理",
        Notes = "家属决定居家护理"
    }
};

            context.Reservations.AddRange(reservations);
        }
        private static void SeedMealRecords(NursingHomeDbContext context)
        {
            // Get actual IDs from database instead of using hardcoded values
            var residents = context.Residents.OrderBy(r => r.Id).Take(6).ToList();

            if (!residents.Any())
            {
                Console.WriteLine("Cannot seed MealRecords: No residents found in database");
                return;
            }
            var mealRecords = new[]
            {
                new MealRecord
                {
                    ResidentId = residents[0].Id,
                    MealDate = new DateTime(2024, 1, 1),
                    MealType = "早餐",
                    MenuItems = "粥、蛋、馒头",
                    Appetite = "良好",
                    SpecialDiet = "低盐饮食",
                    Notes = "进食顺利",
                    CreatedBy = "护理师张美玲"
                },
                new MealRecord
                {
                    ResidentId = residents[0].Id,
                    MealDate = new DateTime(2024, 1, 1),
                    MealType = "午餐",
                    MenuItems = "米饭、鸡肉、青菜",
                    Appetite = "良好",
                    SpecialDiet = "低盐饮食",
                    Notes = "正常进食",
                    CreatedBy = "护理师李志强"
                },
                new MealRecord
                {
                    ResidentId = residents[0].Id,
                    MealDate = new DateTime(2024, 1, 1),
                    MealType = "晚餐",
                    MenuItems = "面条、牛肉、沙拉",
                    Appetite = "一般",
                    SpecialDiet = "低盐饮食",
                    Notes = "食量稍少",
                    CreatedBy = "护理师王淑芬"
                },
                new MealRecord
                {
                    ResidentId = residents[1].Id,
                    MealDate = new DateTime(2024, 1, 1),
                    MealType = "早餐",
                    MenuItems = "燕麦粥、水煮蛋",
                    Appetite = "良好",
                    SpecialDiet = "软食",
                    Notes = "适合咀嚼能力",
                    CreatedBy = "护理师张美玲"
                },
                new MealRecord
                {
                    ResidentId = residents[1].Id,
                    MealDate = new DateTime(2024, 1, 1),
                    MealType = "午餐",
                    MenuItems = "软饭、蒸蛋、菠菜",
                    Appetite = "良好",
                    SpecialDiet = "软食",
                    Notes = "进食完整",
                    CreatedBy = "护理师李志强"
                }
            };

            context.MealRecords.AddRange(mealRecords);
        }

        private static void SeedCareRecords(NursingHomeDbContext context)
        {
            // Get actual IDs from database instead of using hardcoded values
            var residents = context.Residents.OrderBy(r => r.Id).Take(6).ToList();
            var carePackages = context.CarePackages.OrderBy(cp => cp.Id).Take(9).ToList();

            if (!residents.Any() || !carePackages.Any())
            {
                Console.WriteLine("Cannot seed CareRecords: No residents or care packages found in database");
                return;
            }
            var careRecords = new[]
            {
                new CareRecord
                {
                    ResidentId = residents[0].Id,
                    CarePackageId = carePackages[0].Id,
                    CareDate = new DateTime(2024, 1, 1),
                    CareType = "日常护理",
                    CareContent = "协助洗澡、更换衣物",
                    CareResult = "良好",
                    CaregiverName = "护理师张美玲",
                    Notes = "配合度佳"
                },
                new CareRecord
                {
                    ResidentId = residents[0].Id,
                    CarePackageId = carePackages[0].Id,
                    CareDate = new DateTime(2024, 1, 2),
                    CareType = "医疗护理",
                    CareContent = "协助翻身、测量生命体征",
                    CareResult = "良好",
                    CaregiverName = "护理师李志强",
                    Notes = "血压正常"
                },
                new CareRecord
                {
                    ResidentId = residents[1].Id,
                    CarePackageId = carePackages[1].Id,
                    CareDate = new DateTime(2024, 1, 1),
                    CareType = "康复护理",
                    CareContent = "康复运动指导",
                    CareResult = "一般",
                    CaregiverName = "康复师王淑芬",
                    Notes = "需要加强练习"
                },
                new CareRecord
                {
                    ResidentId = residents[2].Id,
                    CarePackageId = carePackages[2].Id,
                    CareDate = new DateTime(2024, 1, 1),
                    CareType = "日常护理",
                    CareContent = "喂食协助、口腔清洁",
                    CareResult = "良好",
                    CaregiverName = "护理师张美玲",
                    Notes = "食欲正常"
                },
                new CareRecord
                {
                    ResidentId = residents[3].Id,
                    CarePackageId = carePackages[1].Id,
                    CareDate = new DateTime(2024, 1, 1),
                    CareType = "医疗护理",
                    CareContent = "药物管理、服药提醒",
                    CareResult = "良好",
                    CaregiverName = "护理师李志强",
                    Notes = "准时服药"
                }
            };

            context.CareRecords.AddRange(careRecords);
        }

        private static void SeedHealthRecords(NursingHomeDbContext context)
        {
            // Get actual IDs from database instead of using hardcoded values
            var residents = context.Residents.OrderBy(r => r.Id).Take(6).ToList();

            if (!residents.Any())
            {
                Console.WriteLine("Cannot seed HealthRecords: No residents found in database");
                return;
            }
            var healthRecords = new[]
            {
                new HealthRecord
                {
                    ResidentId = residents[0].Id,
                    RecordDate = new DateTime(2024, 1, 1),
                    RecordType = "日常监测",
                    BloodPressureHigh = 120,
                    BloodPressureLow = 80,
                    HeartRate = 75,
                    Temperature = 36.5m,
                    BloodSugar = 100,
                    Weight = 60,
                    Height = 160,
                    Symptoms = "无异常症状",
                    Diagnosis = "生命体征正常",
                    Treatment = "持续观察",
                    Notes = "整体状况良好",
                    RecorderName = "护理师张美玲",
                    RecorderType = "护理人员"
                },
                new HealthRecord
                {
                    ResidentId = residents[0].Id,
                    RecordDate = new DateTime(2024, 1, 15),
                    RecordType = "定期体检",
                    BloodPressureHigh = 118,
                    BloodPressureLow = 79,
                    HeartRate = 76,
                    Temperature = 36.3m,
                    BloodSugar = 98,
                    Weight = 59,
                    Height = 160,
                    Symptoms = "无特殊症状",
                    Diagnosis = "健康状况稳定",
                    Treatment = "维持现有护理",
                    Notes = "建议增加运动量",
                    RecorderName = "护理师李志强",
                    RecorderType = "护理人员"
                },
                new HealthRecord
                {
                    ResidentId = residents[1].Id,
                    RecordDate = new DateTime(2024, 1, 1),
                    RecordType = "日常监测",
                    BloodPressureHigh = 135,
                    BloodPressureLow = 85,
                    HeartRate = 82,
                    Temperature = 36.7m,
                    BloodSugar = 140,
                    Weight = 65,
                    Height = 165,
                    Symptoms = "偶有头晕",
                    Diagnosis = "血压偏高需关注",
                    Treatment = "调整药物剂量",
                    Notes = "需密切监测血压",
                    RecorderName = "护理师王淑芬",
                    RecorderType = "护理人员"
                },
                new HealthRecord
                {
                    ResidentId = residents[2].Id,
                    RecordDate = new DateTime(2024, 1, 1),
                    RecordType = "日常监测",
                    BloodPressureHigh = 110,
                    BloodPressureLow = 70,
                    HeartRate = 68,
                    Temperature = 36.2m,
                    BloodSugar = 85,
                    Weight = 52,
                    Height = 155,
                    Symptoms = "食欲不振",
                    Diagnosis = "营养状况需改善",
                    Treatment = "增加营养补充",
                    Notes = "建议营养师咨询",
                    RecorderName = "护理师张美玲",
                    RecorderType = "护理人员"
                },
                new HealthRecord
                {
                    ResidentId = residents[3].Id,
                    RecordDate = new DateTime(2024, 1, 1),
                    RecordType = "日常监测",
                    BloodPressureHigh = 125,
                    BloodPressureLow = 82,
                    HeartRate = 78,
                    Temperature = 36.6m,
                    BloodSugar = 110,
                    Weight = 70,
                    Height = 170,
                    Symptoms = "关节疼痛",
                    Diagnosis = "关节炎症状",
                    Treatment = "物理治疗",
                    Notes = "需要定期康复",
                    RecorderName = "护理师李志强",
                    RecorderType = "护理人员"
                }
            };

            context.HealthRecords.AddRange(healthRecords);
        }

        private static void SeedMedicationRecords(NursingHomeDbContext context)
        {
            // Get actual IDs from database instead of using hardcoded values
            var residents = context.Residents.OrderBy(r => r.Id).Take(6).ToList();
            var medications = context.Medications.OrderBy(m => m.Id).Take(10).ToList();

            if (!residents.Any() || !medications.Any())
            {
                Console.WriteLine("Cannot seed MedicationRecords: No residents or medications found in database");
                return;
            }
            var medicationRecords = new[]
            {
                new MedicationRecord
                {
                    ResidentId = residents[0].Id,
                    MedicationId = medications[0].Id,
                    Dosage = "1片",
                    Frequency = "每日一次",
                    StartDate = new DateTime(2024, 1, 1),
                    EndDate = new DateTime(2024, 1, 31)
                },
                new MedicationRecord
                {
                    ResidentId = residents[0].Id,
                    MedicationId = medications[1].Id,
                    Dosage = "1片",
                    Frequency = "每日两次",
                    StartDate = new DateTime(2024, 1, 1),
                    EndDate = new DateTime(2024, 1, 31)
                }
            };

            context.MedicationRecords.AddRange(medicationRecords);
        }
        private static void SeedMedicalMonitorings(NursingHomeDbContext context)
        {
            var medicalMonitorings = new[]
            {
    new MedicalMonitoring
    {
        ResidentId = 1,
        MonitoringDate = new DateTime(2024, 1, 1),
        MonitoringType = "血压监测",
        MonitoringItem = "收缩压/舒张压",
        Result = "120/80",
        Unit = "mmHg",
        NormalRange = "90-140/60-90",
        Status = "正常",
        Recommendations = "维持规律作息",
        Notes = "早晨测量",
        MonitoredBy = "护理师张美玲"
    },
    new MedicalMonitoring
    {
        ResidentId = 1,
        MonitoringDate = new DateTime(2024, 1, 15),
        MonitoringType = "血糖监测",
        MonitoringItem = "空腹血糖",
        Result = "98",
        Unit = "mg/dL",
        NormalRange = "70-100",
        Status = "正常",
        Recommendations = "继续控制饮食",
        Notes = "空腹8小时后测量",
        MonitoredBy = "护理师李志强"
    },
    new MedicalMonitoring
    {
        ResidentId = 2,
        MonitoringDate = new DateTime(2024, 1, 1),
        MonitoringType = "心率监测",
        MonitoringItem = "静态心率",
        Result = "82",
        Unit = "次/分",
        NormalRange = "60-100",
        Status = "正常",
        Recommendations = "适度运动",
        Notes = "休息状态测量",
        MonitoredBy = "护理师王淑芬"
    },
    new MedicalMonitoring
    {
        ResidentId = 3,
        MonitoringDate = new DateTime(2024, 1, 1),
        MonitoringType = "体温监测",
        MonitoringItem = "额温",
        Result = "36.5",
        Unit = "°C",
        NormalRange = "36.0-37.2",
        Status = "正常",
        Recommendations = "保持正常作息",
        Notes = "晨间测量",
        MonitoredBy = "护理师张美玲"
    },
    new MedicalMonitoring
    {
        ResidentId = 4,
        MonitoringDate = new DateTime(2024, 1, 1),
        MonitoringType = "血压监测",
        MonitoringItem = "收缩压/舒张压",
        Result = "135/85",
        Unit = "mmHg",
        NormalRange = "90-140/60-90",
        Status = "需关注",
        Recommendations = "调整药物，减少盐分摄取",
        Notes = "血压偏高，需持续监测",
        MonitoredBy = "护理师李志强"
    }
};

            context.MedicalMonitorings.AddRange(medicalMonitorings);
        }

        private static void SeedAttendanceRecords(NursingHomeDbContext context)
        {
            var attendanceRecords = new[]
            {
    new AttendanceRecord
    {
        EmployeeId = 1,
        AttendanceDate = new DateTime(2024, 1, 1),
        Status = "出勤"
    },
    new AttendanceRecord
    {
        EmployeeId = 2,
        AttendanceDate = new DateTime(2024, 1, 1),
        Status = "缺勤"
    },
    new AttendanceRecord
    {
        EmployeeId = 3,
        AttendanceDate = new DateTime(2024, 1, 1),
        Status = "遲到"
    }
};

            context.AttendanceRecords.AddRange(attendanceRecords);
        }
        private static void SeedInventories(NursingHomeDbContext context)
        {
            // Get actual IDs from database instead of using hardcoded values
            var warehouses = context.Warehouses.OrderBy(w => w.Id).Take(5).ToList();

            if (!warehouses.Any())
            {
                Console.WriteLine("Cannot seed Inventories: No warehouses found in database");
                return;
            }
            var inventories = new[]
            {
    new Inventory
    {
        ItemId = 1,
        WarehouseId = warehouses[0].Id,
        Quantity = 10,
        Location = "A区-01架",
        Status = "正常",
        BatchNumber = "WC240101",
        ProductionDate = new DateTime(2024, 1, 1),
        LastCheckDate = new DateTime(2024, 1, 15),
        Notes = "轮椅库存正常"
    },
    new Inventory
    {
        ItemId = 2,
        WarehouseId = warehouses[1].Id,
        Quantity = 15,
        Location = "B区-02架",
        Status = "正常",
        BatchNumber = "AW240105",
        ProductionDate = new DateTime(2024, 1, 5),
        LastCheckDate = new DateTime(2024, 1, 20),
        Notes = "助行器库存充足"
    },
    new Inventory
    {
        ItemId = 3,
        WarehouseId = warehouses[2].Id,
        Quantity = 8,
        Location = "C区-03架",
        Status = "正常",
        BatchNumber = "BP240110",
        ProductionDate = new DateTime(2024, 1, 10),
        LastCheckDate = new DateTime(2024, 1, 25),
        Notes = "血压计功能正常"
    },
    new Inventory
    {
        ItemId = 4,
        WarehouseId = warehouses[3].Id,
        Quantity = 12,
        Location = "D区-04架",
        Status = "正常",
        BatchNumber = "TM240115",
        ProductionDate = new DateTime(2024, 1, 15),
        LastCheckDate = new DateTime(2024, 1, 30),
        Notes = "体温计校准正常"
    },
    new Inventory
    {
        ItemId = 5,
        WarehouseId = warehouses[4].Id,
        Quantity = 3,
        Location = "E区-05架",
        Status = "正常",
        BatchNumber = "HB240120",
        ProductionDate = new DateTime(2024, 1, 20),
        LastCheckDate = new DateTime(2024, 2, 1),
        Notes = "病床使用正常"
    }
};

            context.Inventories.AddRange(inventories);
        }
        private static void SeedInventoryTransactions(NursingHomeDbContext context)
        {
            // Get actual IDs from database instead of using hardcoded values
            var warehouses = context.Warehouses.OrderBy(w => w.Id).Take(5).ToList();

            if (!warehouses.Any())
            {
                Console.WriteLine("Cannot seed InventoryTransactions: No warehouses found in database");
                return;
            }
            var inventoryTransactions = new[]
            {
    new InventoryTransaction
    {
        ItemId = 1,
        WarehouseId = warehouses[0].Id,
        TransactionDate = new DateTime(2024, 1, 1),
        Quantity = 5,
        TransactionType = "入库",
        Operator = "仓管员王小明",
        Source = "采购部",
        Reason = "新品入库",
        Notes = "检验合格"
    },
    new InventoryTransaction
    {
        ItemId = 1,
        WarehouseId = warehouses[0].Id,
        TransactionDate = new DateTime(2024, 1, 10),
        Quantity = 2,
        TransactionType = "出库",
        Operator = "仓管员李小华",
        Source = "护理部",
        Reason = "物品需求",
        Notes = "正常使用"
    },
    new InventoryTransaction
    {
        ItemId = 2,
        WarehouseId = warehouses[1].Id,
        TransactionDate = new DateTime(2024, 1, 5),
        Quantity = 10,
        TransactionType = "入库",
        Operator = "仓管员张小美",
        Source = "采购部",
        Reason = "补充库存",
        Notes = "品质良好"
    },
    new InventoryTransaction
    {
        ItemId = 2,
        WarehouseId = warehouses[1].Id,
        TransactionDate = new DateTime(2024, 1, 15),
        Quantity = 5,
        TransactionType = "出库",
        Operator = "仓管员陈小强",
        Source = "康复科",
        Reason = "设备更换",
        Notes = "旧设备报废"
    },
    new InventoryTransaction
    {
        ItemId = 3,
        WarehouseId = warehouses[2].Id,
        TransactionDate = new DateTime(2024, 1, 20),
        Quantity = 8,
        TransactionType = "入库",
        Operator = "仓管员刘小芳",
        Source = "供应商",
        Reason = "定期补货",
        Notes = "按时到货"
    }
};

            context.InventoryTransactions.AddRange(inventoryTransactions);
        }
    }
}
