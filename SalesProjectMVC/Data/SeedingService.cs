using SalesProjectMVC.Models;
using SalesProjectMVC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesProjectMVC.Data
{
    public class SeedingService
    {
        private SalesProjectMVCContext _context;

        public SeedingService(SalesProjectMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; // DB has been seeded
            }

            Department d1 = new Department(id: 1, name: "Computers");
            Department d2 = new Department(id: 2, name: "Electronics");
            Department d3 = new Department(id: 3, name: "Fashion");
            Department d4 = new Department(id: 4, name: "Books");

            Seller s1 = new Seller(id: 1, name: "Bob Brown", email: "bob@gmail.com", birthDate: new DateTime(1988,4,21), baseSalary: 1000.0, department: d1);
            Seller s2 = new Seller(id: 2, name: "Maria Green", email: "maria@gmail.com", birthDate: new DateTime(1986,5,22), baseSalary: 1500.0, department: d2);
            Seller s3 = new Seller(id: 3, name: "Alex Grey", email: "alex@gmail.com", birthDate: new DateTime(1985,6,23), baseSalary: 2000.0, department: d3);
            Seller s4 = new Seller(id: 4, name: "Martha Red", email: "martha@gmail.com", birthDate: new DateTime(1984,7,24), baseSalary: 2500.0, department: d4);
            Seller s5 = new Seller(id: 5, name: "Donald Blue", email: "donald@gmail.com", birthDate: new DateTime(1983,8,25), baseSalary: 175000.0, department: d1);
            Seller s6 = new Seller(id: 6, name: "Alex Pink", email: "pink@gmail.com", birthDate: new DateTime(1989,9,26), baseSalary: 1800.0, department: d3);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 09, 4), 7000.0, SaleStatus.Billed, s5);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2018, 09, 13), 4000.0, SaleStatus.Canceled, s4);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2018, 09, 1), 8000.0, SaleStatus.Billed, s1);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2018, 09, 21), 3000.0, SaleStatus.Billed, s3);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2018, 09, 15), 2000.0, SaleStatus.Billed, s1);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2018, 09, 28), 13000.0, SaleStatus.Billed, s2);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2018, 09, 11), 4000.0, SaleStatus.Billed, s4);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2018, 09, 14), 11000.0, SaleStatus.Pending, s6);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2018, 09, 7), 9000.0, SaleStatus.Billed, s6);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2018, 09, 13), 6000.0, SaleStatus.Billed, s2);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2018, 09, 25), 7000.0, SaleStatus.Pending, s3);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2018, 09, 29), 10000.0, SaleStatus.Billed, s4);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2018, 09, 4), 3000.0, SaleStatus.Billed, s5);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2018, 09, 12), 4000.0, SaleStatus.Billed, s1);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2018, 10, 5), 2000.0, SaleStatus.Billed, s4);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2018, 10, 1), 12000.0, SaleStatus.Billed, s1);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2018, 10, 24), 6000.0, SaleStatus.Billed, s3);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2018, 10, 22), 8000.0, SaleStatus.Billed, s5);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2018, 10, 15), 8000.0, SaleStatus.Billed, s6);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2018, 10, 17), 9000.0, SaleStatus.Billed, s2);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2018, 10, 24), 4000.0, SaleStatus.Billed, s4);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2018, 10, 19), 11000.0, SaleStatus.Canceled, s2);
            SalesRecord r24 = new SalesRecord(24, new DateTime(2018, 10, 12), 8000.0, SaleStatus.Billed, s5);
            SalesRecord r25 = new SalesRecord(25, new DateTime(2018, 10, 31), 7000.0, SaleStatus.Billed, s3);
            SalesRecord r26 = new SalesRecord(26, new DateTime(2018, 10, 6), 5000.0, SaleStatus.Billed, s4);
            SalesRecord r27 = new SalesRecord(27, new DateTime(2018, 10, 13), 9000.0, SaleStatus.Pending, s1);
            SalesRecord r28 = new SalesRecord(28, new DateTime(2018, 10, 7), 4000.0, SaleStatus.Billed, s3);
            SalesRecord r29 = new SalesRecord(29, new DateTime(2018, 10, 23), 12000.0, SaleStatus.Billed, s5);
            SalesRecord r30 = new SalesRecord(30, new DateTime(2018, 10, 12), 5000.0, SaleStatus.Billed, s2);

            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SalesRecord.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
            r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
            );

            _context.SaveChanges();
        }
    }
}
