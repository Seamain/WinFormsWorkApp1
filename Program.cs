using WinFormsWorkApp1.Forms;
using WinFormsWorkApp1.Helpers;

namespace WinFormsWorkApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();            // 在显示窗口之前先填充数据
            try
            {
                // 创建日志文件
                var logFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "seeding_log.txt");
                File.WriteAllText(logFile, $"开始数据填充 - {DateTime.Now}\n"); using (var context = new NursingHomeDbContext())
                {
                    DataSeeder.SeedData(context);

                    // === 住户数据诊断 ===
                    var diagnosticFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "diagnostic_log.txt");
                    var diagnosticOutput = new List<string>();

                    diagnosticOutput.Add("=== 住户数据诊断开始 ===");
                    var residents = context.Residents.Take(5).ToList();
                    diagnosticOutput.Add($"住户总数: {context.Residents.Count()}");

                    if (residents.Any())
                    {
                        diagnosticOutput.Add("前5个住户详细信息:");
                        foreach (var resident in residents)
                        {
                            diagnosticOutput.Add($"ID: {resident.Id}, 姓名: '{resident.Name}' (长度: {resident.Name?.Length ?? 0}), 性别: '{resident.Gender}', 状态: '{resident.Status}'");
                        }

                        // 测试健康记录关联
                        var firstResidentId = residents[0].Id;
                        var healthRecordsForFirstResident = context.HealthRecords
                            .Where(hr => hr.ResidentId == firstResidentId)
                            .ToList();
                        diagnosticOutput.Add($"第一个住户(ID:{firstResidentId})的健康记录数: {healthRecordsForFirstResident.Count}");

                        // 检查所有健康记录的住户ID
                        var allHealthRecords = context.HealthRecords.ToList();
                        diagnosticOutput.Add($"所有健康记录数: {allHealthRecords.Count}");

                        if (allHealthRecords.Any())
                        {
                            foreach (var hr in allHealthRecords)
                            {
                                var residentExists = context.Residents.Any(r => r.Id == hr.ResidentId);
                                diagnosticOutput.Add($"健康记录ID:{hr.Id}, 住户ID:{hr.ResidentId}, 住户存在:{residentExists}");
                            }
                        }
                        else
                        {
                            diagnosticOutput.Add("警告: 健康记录表为空! 检查DataSeeder.SeedHealthRecords方法是否被正确调用");
                        }

                        // 强制重新尝试填充健康记录
                        diagnosticOutput.Add("=== 尝试重新填充健康记录 ===");
                        try
                        {
                            if (!context.HealthRecords.Any())
                            {
                                // 直接调用SeedHealthRecords
                                var healthRecords = new[]
                                {
                                    new Models.HealthRecord
                                    {
                                        ResidentId = residents[0].Id,
                                        RecordDate = new DateTime(2024, 1, 1),
                                        RecordType = "测试记录",
                                        BloodPressureHigh = 120,
                                        BloodPressureLow = 80,
                                        HeartRate = 75,
                                        Temperature = 36.5m,
                                        BloodSugar = 100,
                                        Weight = 60,
                                        Height = 160,
                                        Symptoms = "测试症状",
                                        Diagnosis = "测试诊断",
                                        Treatment = "测试治疗",
                                        Notes = "测试备注",
                                        RecorderName = "测试记录员",
                                        RecorderType = "护理人员"
                                    }
                                };

                                context.HealthRecords.AddRange(healthRecords);
                                context.SaveChanges();
                                diagnosticOutput.Add($"手动添加健康记录成功，新增 {healthRecords.Length} 条记录");
                            }
                        }
                        catch (Exception ex)
                        {
                            diagnosticOutput.Add($"手动添加健康记录失败: {ex.Message}");
                            diagnosticOutput.Add($"内部异常: {ex.InnerException?.Message ?? "无内部异常"}");
                            diagnosticOutput.Add($"堆栈跟踪: {ex.StackTrace}");

                            // 尝试查看数据库架构信息
                            try
                            {
                                var healthRecordTable = context.Model.FindEntityType(typeof(Models.HealthRecord));
                                if (healthRecordTable != null)
                                {
                                    diagnosticOutput.Add("HealthRecord 表结构信息:");
                                    foreach (var property in healthRecordTable.GetProperties())
                                    {
                                        diagnosticOutput.Add($"  {property.Name}: {property.ClrType.Name}, 必需: {!property.IsNullable}");
                                    }
                                }
                            }
                            catch (Exception schemaEx)
                            {
                                diagnosticOutput.Add($"获取表结构信息失败: {schemaEx.Message}");
                            }
                        }
                    }
                    else
                    {
                        diagnosticOutput.Add("警告: 住户表为空!");
                    }
                    diagnosticOutput.Add("=== 住户数据诊断结束 ===");

                    File.WriteAllLines(diagnosticFile, diagnosticOutput);

                    // 检查数据库中的记录数量 - 所有23个表
                    var employeeCount = context.Employees.Count();
                    var residentCount = context.Residents.Count();
                    var bedCount = context.Beds.Count();
                    var itemCount = context.Items.Count();
                    var medicationCount = context.Medications.Count();
                    var carePackageCount = context.CarePackages.Count();
                    var feeTypeCount = context.FeeTypes.Count();
                    var feeRecordCount = context.FeeRecords.Count();
                    var paymentRecordCount = context.PaymentRecords.Count();
                    var outingRecordCount = context.OutingRecords.Count();
                    var leaveRecordCount = context.LeaveRecords.Count();
                    var consultantCount = context.Consultants.Count();
                    var facilityCount = context.Facilities.Count();
                    var warehouseCount = context.Warehouses.Count();
                    var reservationCount = context.Reservations.Count();
                    var mealRecordCount = context.MealRecords.Count();
                    var careRecordCount = context.CareRecords.Count();
                    var healthRecordCount = context.HealthRecords.Count();
                    var medicationRecordCount = context.MedicationRecords.Count();
                    var medicalMonitoringCount = context.MedicalMonitorings.Count();
                    var attendanceRecordCount = context.AttendanceRecords.Count();
                    var inventoryCount = context.Inventories.Count();
                    var inventoryTransactionCount = context.InventoryTransactions.Count();

                    var logContent = $@"数据填充完成 - {DateTime.Now}
=== 基础表 (Base Tables) ===
员工记录: {employeeCount}
住户记录: {residentCount}
床位记录: {bedCount}
物品记录: {itemCount}
药物记录: {medicationCount}
护理套餐记录: {carePackageCount}
费用类型记录: {feeTypeCount}
顾问记录: {consultantCount}
设施记录: {facilityCount}
仓库记录: {warehouseCount}

=== 关联表 (Dependent Tables) ===
费用记录: {feeRecordCount}
缴费记录: {paymentRecordCount}
外出记录: {outingRecordCount}
请假记录: {leaveRecordCount}
预约记录: {reservationCount}
用餐记录: {mealRecordCount}
护理记录: {careRecordCount}
健康记录: {healthRecordCount}
用药记录: {medicationRecordCount}
医疗监控记录: {medicalMonitoringCount}
考勤记录: {attendanceRecordCount}
库存记录: {inventoryCount}
库存交易记录: {inventoryTransactionCount}

总计表数: 23
总计记录数: {employeeCount + residentCount + bedCount + itemCount + medicationCount + carePackageCount + feeTypeCount + consultantCount + facilityCount + warehouseCount + feeRecordCount + paymentRecordCount + outingRecordCount + leaveRecordCount + reservationCount + mealRecordCount + careRecordCount + healthRecordCount + medicationRecordCount + medicalMonitoringCount + attendanceRecordCount + inventoryCount + inventoryTransactionCount}
";
                    File.AppendAllText(logFile, logContent);
                }
                Console.WriteLine("数据库初始化完成！");
            }
            catch (Exception ex)
            {
                var logFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "seeding_log.txt");
                var errorDetails = $"错误: {ex.Message}\n";
                if (ex.InnerException != null)
                {
                    errorDetails += $"内部错误: {ex.InnerException.Message}\n";
                    if (ex.InnerException.InnerException != null)
                    {
                        errorDetails += $"深层错误: {ex.InnerException.InnerException.Message}\n";
                    }
                }
                errorDetails += $"堆栈跟踪: {ex.StackTrace}\n";
                File.AppendAllText(logFile, errorDetails);
                MessageBox.Show($"数据库初始化失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // 显示登录窗口
            var loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // 登录成功，显示主窗口
                Application.Run(new Form1());
            }
        }
    }
}