using System.IO;
using Microsoft.EntityFrameworkCore;
using WinFormsWorkApp1.Models;

namespace WinFormsWorkApp1.Helpers
{
    public class NursingHomeDbContext : DbContext
    {
        public DbSet<Consultant> Consultants { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Bed> Beds { get; set; }
        public DbSet<Resident> Residents { get; set; }
        public DbSet<OutingRecord> OutingRecords { get; set; }
        public DbSet<MealRecord> MealRecords { get; set; }
        public DbSet<CarePackage> CarePackages { get; set; }
        public DbSet<CareRecord> CareRecords { get; set; }
        public DbSet<FeeType> FeeTypes { get; set; }
        public DbSet<FeeRecord> FeeRecords { get; set; }
        public DbSet<PaymentRecord> PaymentRecords { get; set; }
        public DbSet<HealthRecord> HealthRecords { get; set; }
        public DbSet<Medication> Medications { get; set; }
        public DbSet<MedicationRecord> MedicationRecords { get; set; }
        public DbSet<MedicalMonitoring> MedicalMonitorings { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<LeaveRecord> LeaveRecords { get; set; }
        public DbSet<AttendanceRecord> AttendanceRecords { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<InventoryTransaction> InventoryTransactions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // 获取应用程序根目录，确保调试和发布模式都能正确访问数据库
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string dbPath = Path.Combine(baseDirectory, "NursingHome.accdb");

            // 如果在Debug目录下找不到数据库文件，尝试在项目根目录查找
            if (!File.Exists(dbPath))
            {
                string? projectRoot = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(baseDirectory)));
                if (!string.IsNullOrEmpty(projectRoot))
                {
                    string projectDbPath = Path.Combine(projectRoot, "NursingHome.accdb");
                    if (File.Exists(projectDbPath))
                    {
                        dbPath = projectDbPath;
                    }
                }
            }

            // Access数据库连接字符串，使用绝对路径
            string connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath};Persist Security Info=False;";
            optionsBuilder.UseJet(connectionString)
                .ConfigureWarnings(warnings =>
                    warnings.Ignore(Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.PendingModelChangesWarning));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 配置decimal字段的精度和标度
            ConfigureDecimalProperties(modelBuilder);

            // 配置实体关系
            ConfigureEntityRelationships(modelBuilder);

            // 初始化数据
            SeedData(modelBuilder);
        }

        private void ConfigureDecimalProperties(ModelBuilder modelBuilder)
        {
            // 配置Bed实体的decimal属性
            modelBuilder.Entity<Bed>()
                .Property(b => b.MonthlyRate)
                .HasColumnType("DECIMAL(10,2)");

            // 配置CarePackage实体的decimal属性
            modelBuilder.Entity<CarePackage>()
                .Property(cp => cp.MonthlyPrice)
                .HasColumnType("DECIMAL(10,2)");

            // 配置Facility实体的decimal属性
            modelBuilder.Entity<Facility>()
                .Property(f => f.PurchasePrice)
                .HasColumnType("DECIMAL(10,2)");

            // 配置FeeRecord实体的decimal属性
            modelBuilder.Entity<FeeRecord>()
                .Property(fr => fr.Amount)
                .HasColumnType("DECIMAL(10,2)");

            // 配置FeeType实体的decimal属性
            modelBuilder.Entity<FeeType>()
                .Property(ft => ft.StandardPrice)
                .HasColumnType("DECIMAL(10,2)");

            // 配置HealthRecord实体的decimal属性
            modelBuilder.Entity<HealthRecord>()
                .Property(hr => hr.BloodPressureHigh)
                .HasColumnType("DECIMAL(5,1)");

            modelBuilder.Entity<HealthRecord>()
                .Property(hr => hr.BloodPressureLow)
                .HasColumnType("DECIMAL(5,1)");

            modelBuilder.Entity<HealthRecord>()
                .Property(hr => hr.BloodSugar)
                .HasColumnType("DECIMAL(5,2)");

            modelBuilder.Entity<HealthRecord>()
                .Property(hr => hr.HeartRate)
                .HasColumnType("DECIMAL(5,1)");

            modelBuilder.Entity<HealthRecord>()
                .Property(hr => hr.Height)
                .HasColumnType("DECIMAL(5,2)");

            modelBuilder.Entity<HealthRecord>()
                .Property(hr => hr.Temperature)
                .HasColumnType("DECIMAL(4,1)");

            modelBuilder.Entity<HealthRecord>()
                .Property(hr => hr.Weight)
                .HasColumnType("DECIMAL(5,2)");

            // 配置Item实体的decimal属性
            modelBuilder.Entity<Item>()
                .Property(i => i.PurchasePrice)
                .HasColumnType("DECIMAL(10,2)");

            // 配置LeaveRecord实体的decimal属性
            modelBuilder.Entity<LeaveRecord>()
                .Property(lr => lr.Days)
                .HasColumnType("DECIMAL(4,1)");

            // 配置PaymentRecord实体的decimal属性
            modelBuilder.Entity<PaymentRecord>()
                .Property(pr => pr.PaymentAmount)
                .HasColumnType("DECIMAL(10,2)");

            // 配置Warehouse实体的decimal属性
            modelBuilder.Entity<Warehouse>()
                .Property(w => w.Area)
                .HasColumnType("DECIMAL(8,2)");
        }

        private void ConfigureEntityRelationships(ModelBuilder modelBuilder)
        {
            // 配置预约关系
            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.Consultant)
                .WithMany(c => c.Reservations)
                .HasForeignKey(r => r.ConsultantId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.Bed)
                .WithMany(b => b.Reservations)
                .HasForeignKey(r => r.BedId)
                .OnDelete(DeleteBehavior.SetNull);

            // 配置老人与床位的关系
            modelBuilder.Entity<Resident>()
                .HasOne(r => r.Bed)
                .WithMany()
                .HasForeignKey(r => r.BedId)
                .OnDelete(DeleteBehavior.SetNull);

            // 配置外出记录关系
            modelBuilder.Entity<OutingRecord>()
                .HasOne(o => o.Resident)
                .WithMany()
                .HasForeignKey(o => o.ResidentId)
                .OnDelete(DeleteBehavior.Cascade);

            // 配置餐饮记录关系
            modelBuilder.Entity<MealRecord>()
                .HasOne(m => m.Resident)
                .WithMany()
                .HasForeignKey(m => m.ResidentId)
                .OnDelete(DeleteBehavior.Cascade);

            // 配置护理记录关系
            modelBuilder.Entity<CareRecord>()
                .HasOne(c => c.Resident)
                .WithMany()
                .HasForeignKey(c => c.ResidentId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CareRecord>()
                .HasOne(c => c.CarePackage)
                .WithMany(p => p.CareRecords)
                .HasForeignKey(c => c.CarePackageId)
                .OnDelete(DeleteBehavior.SetNull);

            // 配置费用记录关系
            modelBuilder.Entity<FeeRecord>()
                .HasOne(f => f.Resident)
                .WithMany()
                .HasForeignKey(f => f.ResidentId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<FeeRecord>()
                .HasOne(f => f.FeeType)
                .WithMany(ft => ft.FeeRecords)
                .HasForeignKey(f => f.FeeTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            // 配置缴费记录关系
            modelBuilder.Entity<PaymentRecord>()
                .HasOne(p => p.FeeRecord)
                .WithMany(f => f.PaymentRecords)
                .HasForeignKey(p => p.FeeRecordId)
                .OnDelete(DeleteBehavior.Cascade);

            // 配置健康记录关系
            modelBuilder.Entity<HealthRecord>()
                .HasOne(h => h.Resident)
                .WithMany()
                .HasForeignKey(h => h.ResidentId)
                .OnDelete(DeleteBehavior.Cascade);

            // 配置用药记录关系
            modelBuilder.Entity<MedicationRecord>()
                .HasOne(mr => mr.Resident)
                .WithMany()
                .HasForeignKey(mr => mr.ResidentId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<MedicationRecord>()
                .HasOne(mr => mr.Medication)
                .WithMany(m => m.MedicationRecords)
                .HasForeignKey(mr => mr.MedicationId)
                .OnDelete(DeleteBehavior.Restrict);

            // 配置医疗监测关系
            modelBuilder.Entity<MedicalMonitoring>()
                .HasOne(mm => mm.Resident)
                .WithMany()
                .HasForeignKey(mm => mm.ResidentId)
                .OnDelete(DeleteBehavior.Cascade);

            // 配置请假记录关系
            modelBuilder.Entity<LeaveRecord>()
                .HasOne(l => l.Employee)
                .WithMany()
                .HasForeignKey(l => l.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            // 配置考勤记录关系
            modelBuilder.Entity<AttendanceRecord>()
                .HasOne(a => a.Employee)
                .WithMany()
                .HasForeignKey(a => a.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            // 配置物品与库存的关系
            modelBuilder.Entity<Inventory>()
                .HasOne(i => i.Item)
                .WithMany(item => item.Inventories)
                .HasForeignKey(i => i.ItemId)
                .OnDelete(DeleteBehavior.Cascade);

            // 配置仓库与库存的关系
            modelBuilder.Entity<Inventory>()
                .HasOne(i => i.Warehouse)
                .WithMany()
                .HasForeignKey(i => i.WarehouseId)
                .OnDelete(DeleteBehavior.Cascade);

            // 配置物品与库存交易的关系
            modelBuilder.Entity<InventoryTransaction>()
                .HasOne(t => t.Item)
                .WithMany()
                .HasForeignKey(t => t.ItemId)
                .OnDelete(DeleteBehavior.Cascade);

            // 配置仓库与库存交易的关系
            modelBuilder.Entity<InventoryTransaction>()
                .HasOne(t => t.Warehouse)
                .WithMany()
                .HasForeignKey(t => t.WarehouseId)
                .OnDelete(DeleteBehavior.Cascade);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            var baseDate = new DateTime(2024, 1, 1);

            SeedBedData(modelBuilder, baseDate);
            SeedCarePackageData(modelBuilder, baseDate);
            SeedFeeTypeData(modelBuilder, baseDate);
            SeedMedicationData(modelBuilder, baseDate);
        }

        private void SeedBedData(ModelBuilder modelBuilder, DateTime baseDate)
        {
            var beds = new List<Bed>();
            int currentId = 1;

            // 创建示例床位数据
            for (int floor = 1; floor <= 3; floor++)
            {
                for (int room = 1; room <= 10; room++)
                {
                    string roomNumber = $"{floor}{room:D2}";

                    // 单人间
                    if (room <= 5)
                    {
                        beds.Add(new Bed
                        {
                            Id = currentId++,
                            BedNumber = $"{roomNumber}-01",
                            RoomNumber = roomNumber,
                            RoomType = "单人间",
                            Status = "空闲",
                            MonthlyRate = 3000m,
                            Facilities = "独立卫生间、空调、电视、衣柜",
                            CreateTime = baseDate
                        });
                    }
                    // 双人间
                    else
                    {
                        for (int bed = 1; bed <= 2; bed++)
                        {
                            beds.Add(new Bed
                            {
                                Id = currentId++,
                                BedNumber = $"{roomNumber}-{bed:D2}",
                                RoomNumber = roomNumber,
                                RoomType = "双人间",
                                Status = "空闲",
                                MonthlyRate = 2000m,
                                Facilities = "共用卫生间、空调、电视、衣柜",
                                CreateTime = baseDate
                            });
                        }
                    }
                }
            }

            modelBuilder.Entity<Bed>().HasData(beds);
        }

        private void SeedCarePackageData(ModelBuilder modelBuilder, DateTime baseDate)
        {
            var carePackages = new List<CarePackage>
            {
                new CarePackage
                {
                    Id = 1,
                    PackageName = "基础护理套餐",
                    Description = "适合生活能够自理的老人",
                    ServiceItems = "日常生活协助、健康监测、定期查房、紧急呼叫",
                    MonthlyPrice = 800m,
                    CareLevel = "自理",
                    CreateTime = baseDate
                },
                new CarePackage
                {
                    Id = 2,
                    PackageName = "半护理套餐",
                    Description = "适合部分生活需要协助的老人",
                    ServiceItems = "日常生活协助、个人卫生护理、用药提醒、康复训练、健康监测",
                    MonthlyPrice = 1500m,
                    CareLevel = "半护理",
                    CreateTime = baseDate
                },
                new CarePackage
                {
                    Id = 3,
                    PackageName = "全护理套餐",
                    Description = "适合生活完全不能自理的老人",
                    ServiceItems = "全面生活护理、医疗护理、康复训练、心理关怀、24小时监护",
                    MonthlyPrice = 2500m,
                    CareLevel = "全护理",
                    CreateTime = baseDate
                },
                new CarePackage
                {
                    Id = 4,
                    PackageName = "特护套餐",
                    Description = "适合有特殊医疗需求的老人",
                    ServiceItems = "专业医疗护理、特殊设备使用、专人24小时陪护、医生定期巡诊",
                    MonthlyPrice = 4000m,
                    CareLevel = "特护",
                    CreateTime = baseDate
                }
            };

            modelBuilder.Entity<CarePackage>().HasData(carePackages);
        }

        private void SeedFeeTypeData(ModelBuilder modelBuilder, DateTime baseDate)
        {
            modelBuilder.Entity<FeeType>().HasData(
                new FeeType { Id = 1, TypeName = "床位费", Description = "每月床位租赁费用", IsActive = true, CreateTime = baseDate },
                new FeeType { Id = 2, TypeName = "护理费", Description = "护理服务费用", IsActive = true, CreateTime = baseDate },
                new FeeType { Id = 3, TypeName = "餐饮费", Description = "一日三餐费用", IsActive = true, CreateTime = baseDate },
                new FeeType { Id = 4, TypeName = "医疗费", Description = "医疗服务和药品费用", IsActive = true, CreateTime = baseDate },
                new FeeType { Id = 5, TypeName = "生活用品费", Description = "日常生活用品费用", IsActive = true, CreateTime = baseDate },
                new FeeType { Id = 6, TypeName = "娱乐活动费", Description = "文娱活动参与费用", IsActive = true, CreateTime = baseDate },
                new FeeType { Id = 7, TypeName = "其他费用", Description = "其他杂项费用", IsActive = true, CreateTime = baseDate }
            );
        }

        private void SeedMedicationData(ModelBuilder modelBuilder, DateTime baseDate)
        {
            modelBuilder.Entity<Medication>().HasData(
                new Medication { Id = 1, MedicationName = "阿司匹林", MedicationType = "心血管药物", Specification = "100mg*30片", Manufacturer = "拜耳", Indications = "预防心脑血管疾病", CreateTime = baseDate },
                new Medication { Id = 2, MedicationName = "降压灵", MedicationType = "降压药", Specification = "5mg*28片", Manufacturer = "诺华", Indications = "高血压治疗", CreateTime = baseDate },
                new Medication { Id = 3, MedicationName = "二甲双胍", MedicationType = "降糖药", Specification = "500mg*30片", Manufacturer = "默克", Indications = "2型糖尿病治疗", CreateTime = baseDate },
                new Medication { Id = 4, MedicationName = "钙片", MedicationType = "营养补充剂", Specification = "600mg*60片", Manufacturer = "汤臣倍健", Indications = "补充钙质", CreateTime = baseDate },
                new Medication { Id = 5, MedicationName = "维生素D", MedicationType = "维生素", Specification = "400IU*90粒", Manufacturer = "善存", Indications = "促进钙吸收", CreateTime = baseDate }
            );
        }
    }
}