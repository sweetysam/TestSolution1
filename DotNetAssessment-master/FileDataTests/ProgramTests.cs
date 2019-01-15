﻿//James.Warner
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void createTestFileTest()
        {
            Assert.Fail();
        }
        
        /*Params:
         * v1 = "-v"
         * v2 = "--v"
         * v3 = "/ v"
         * v4 = "/v"
         */

        [TestMethod()]
        public void testMethodUsing_v1()
        { // return string.Format("{0}.{1}.{2}", _random.Next(5), _random.Next(8), _random.Next(22));
            string returnValue = null;
            char seperator = '.';
            string[] splitValues = null;
            int currentValue = 0;
            bool flag = false;

            returnValue = Program.method("-v", "");
            splitValues = returnValue.Split(seperator);

            for(int i = 0; i < 2; i++)
            {
              switch (i)
                {
                    case 0:
                        currentValue = int.Parse(splitValues[i]);  
                        if(currentValue > 0 && currentValue <= 5)
                        {
                            Console.WriteLine("Value" + i + " 0-5 True");
                            flag = true;
                        }
                        else
                        {
                            Console.WriteLine("Value" + i + " 0-5 False");
                            flag = false;
                        }
                        break;
                    case 1:
                        if (currentValue > 0 && currentValue <= 8)
                        {
                            Console.WriteLine("Value" + i + " 0-8 True");
                            flag = true;
                        }
                        else
                        {
                            Console.WriteLine("Value" + i + " 0-8 False");
                            flag = false;
                        }
                        break;
                    case 2:
                        if (currentValue > 0 && currentValue <= 22)
                        {
                            Console.WriteLine("Value" + i + " 0-22 True");
                            flag = true;
                        }
                        else
                        {
                            Console.WriteLine("Value" + i + " 0-22 False");
                            flag = false;
                        }
                        break;
                    default:
                        flag = false;
                        Assert.Fail();
                        break;
                }
            }
            if (flag)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.Fail();
            }

            returnValue = null;
            splitValues = null;
            currentValue = 0;
            flag = false;
        }

        [TestMethod()]
        public void testMethodUsing_v2()
        {
            string returnValue = null;
            char seperator = '.';
            string[] splitValues = null;
            int currentValue = 0;
            bool flag = false;

            returnValue = Program.method("--v", "");
            splitValues = returnValue.Split(seperator);

            for (int i = 0; i < 2; i++)
            {
                switch (i)
                {
                    case 0:
                        currentValue = int.Parse(splitValues[i]);
                        if (currentValue > 0 && currentValue <= 5)
                        {
                            Console.WriteLine("Value" + i + " 0-5 True");
                            flag = true;
                        }
                        else
                        {
                            Console.WriteLine("Value" + i + " 0-5 False");
                            flag = false;
                        }
                        break;
                    case 1:
                        if (currentValue > 0 && currentValue <= 8)
                        {
                            Console.WriteLine("Value" + i + " 0-8 True");
                            flag = true;
                        }
                        else
                        {
                            Console.WriteLine("Value" + i + " 0-8 False");
                            flag = false;
                        }
                        break;
                    case 2:
                        if (currentValue > 0 && currentValue <= 22)
                        {
                            Console.WriteLine("Value" + i + " 0-22 True");
                            flag = true;
                        }
                        else
                        {
                            Console.WriteLine("Value" + i + " 0-22 False");
                            flag = false;
                        }
                        break;
                    default:
                        flag = false;
                        Assert.Fail();
                        break;
                }
            }
            if (flag)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.Fail();
            }

            returnValue = null;
            splitValues = null;
            currentValue = 0;
            flag = false;
        }

        [TestMethod()]
        public void testMethodUsing_v3()
        {
            string returnValue = null;
            char seperator = '.';
            string[] splitValues = null;
            int currentValue = 0;
            bool flag = false;

            returnValue = Program.method("/ v", "");
            splitValues = returnValue.Split(seperator);

            for (int i = 0; i < 2; i++)
            {
                switch (i)
                {
                    case 0:
                        currentValue = int.Parse(splitValues[i]);
                        if (currentValue > 0 && currentValue <= 5)
                        {
                            Console.WriteLine("Value" + i + " 0-5 True");
                            flag = true;
                        }
                        else
                        {
                            Console.WriteLine("Value" + i + " 0-5 False");
                            flag = false;
                        }
                        break;
                    case 1:
                        if (currentValue > 0 && currentValue <= 8)
                        {
                            Console.WriteLine("Value" + i + " 0-8 True");
                            flag = true;
                        }
                        else
                        {
                            Console.WriteLine("Value" + i + " 0-8 False");
                            flag = false;
                        }
                        break;
                    case 2:
                        if (currentValue > 0 && currentValue <= 22)
                        {
                            Console.WriteLine("Value" + i + " 0-22 True");
                            flag = true;
                        }
                        else
                        {
                            Console.WriteLine("Value" + i + " 0-22 False");
                            flag = false;
                        }
                        break;
                    default:
                        flag = false;
                        Assert.Fail();
                        break;
                }
            }
            if (flag)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.Fail();
            }

            returnValue = null;
            splitValues = null;
            currentValue = 0;
            flag = false;
        }

        [TestMethod()]
        public void testMethodUsing_v4()
        {
            string returnValue = null;
            char seperator = '.';
            string[] splitValues = null;
            int currentValue = 0;
            bool flag = false;

            returnValue = Program.method("/v", "");
            splitValues = returnValue.Split(seperator);

            for (int i = 0; i < 2; i++)
            {
                switch (i)
                {
                    case 0:
                        currentValue = int.Parse(splitValues[i]);
                        if (currentValue > 0 && currentValue <= 5)
                        {
                            Console.WriteLine("Value" + i + " 0-5 True");
                            flag = true;
                        }
                        else
                        {
                            Console.WriteLine("Value" + i + " 0-5 False");
                            flag = false;
                        }
                        break;
                    case 1:
                        if (currentValue > 0 && currentValue <= 8)
                        {
                            Console.WriteLine("Value" + i + " 0-8 True");
                            flag = true;
                        }
                        else
                        {
                            Console.WriteLine("Value" + i + " 0-8 False");
                            flag = false;
                        }
                        break;
                    case 2:
                        if (currentValue > 0 && currentValue <= 22)
                        {
                            Console.WriteLine("Value" + i + " 0-22 True");
                            flag = true;
                        }
                        else
                        {
                            Console.WriteLine("Value" + i + " 0-22 False");
                            flag = false;
                        }
                        break;
                    default:
                        flag = false;
                        Assert.Fail();
                        break;
                }
            }
            if (flag)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.Fail();
            }

            returnValue = null;
            splitValues = null;
            currentValue = 0;
            flag = false;
        }



        
        [TestMethod()]
        public void testMethodUsing_s1()
        {
            int returnValue = 0;
            returnValue = int.Parse(Program.method("", "-s"));
            if(returnValue <= 200000)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void testMethodUsing_s2()
        {
            int returnValue = 0;
            returnValue = int.Parse(Program.method("", "--s"));
            if (returnValue <= 200000)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void testMethodUsing_s3()
        {
            int returnValue = 0;
            returnValue = int.Parse(Program.method("", "/ s"));
            if (returnValue <= 200000)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void testMethodUsing_s4()
        {
            int returnValue = 0;
            returnValue = int.Parse(Program.method("", "/s"));
            if (returnValue <= 200000)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.Fail();
            }
        }


        [TestMethod()]
        public void testWriteOutputUsing_v1()
        {
            string returnValue = null;
            string[] inputParam=  new string[] { "-v", "C:/test.txt" };
            char seperator = '.';
            string[] splitValues = null;
            int currentValue = 0;
            bool flag = false;

            returnValue = Program.WriteOutPut(inputParam);
            splitValues = returnValue.Split(seperator);

            for (int i = 0; i < 2; i++)
            {
                switch (i)
                {
                    case 0:
                        currentValue = int.Parse(splitValues[i]);
                        if (currentValue > 0 && currentValue <= 5)
                        {
                            Console.WriteLine("Value" + i + " 0-5 True");
                            flag = true;
                        }
                        else
                        {
                            Console.WriteLine("Value" + i + " 0-5 False");
                            flag = false;
                        }
                        break;
                    case 1:
                        if (currentValue > 0 && currentValue <= 8)
                        {
                            Console.WriteLine("Value" + i + " 0-8 True");
                            flag = true;
                        }
                        else
                        {
                            Console.WriteLine("Value" + i + " 0-8 False");
                            flag = false;
                        }
                        break;
                    case 2:
                        if (currentValue > 0 && currentValue <= 22)
                        {
                            Console.WriteLine("Value" + i + " 0-22 True");
                            flag = true;
                        }
                        else
                        {
                            Console.WriteLine("Value" + i + " 0-22 False");
                            flag = false;
                        }
                        break;
                    default:
                        flag = false;
                        Assert.Fail();
                        break;
                }
            }
            if (flag)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.Fail();
            }

            returnValue = null;
            splitValues = null;
            currentValue = 0;
            flag = false;
        }

        [TestMethod()]
        public void testWriteOutputUsing_s1()
        {
            int returnValue = 0;
            returnValue = int.Parse(Program.method("-s", "C:/test.txt"));
            if (returnValue <= 200000)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}