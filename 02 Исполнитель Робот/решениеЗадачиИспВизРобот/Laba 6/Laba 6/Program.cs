using ��������������������������������������;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace Laba_6
{
    static class Program
    {
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        static ������������� ��������;
        static ��������� �����;
        static �������������� ����;
        static �������������� ���������������������()
        {
            Random �������������� = new Random();
            int ������ = ��������.����������;
            int ������ = ��������.����������;
            int ����������� = ��������������.Next(2, ������ - 1);
int ������������������ = ��������������.Next(1, ������ / 2);
            int ����������������� = ��������������.Next(������ / 2, ������ - 2);
            ��������.���������������(0, 0);
            // ��������� ����� � ������� ������, ������� ������ ���� ���������
            for (int ������� = ������������������; ������� < �����������������; �������++)
            {
                ��������.��������������(�������, �����������, 8); // ����� ������ ����
                for (int ��� = �����������; ��� < ������; ���++)
                {
                    ��������.��������(�������, ���, 0, 'Z');
                }
            }
            ��������.�������������("Inlet.in");
            // ���������� ����� ������� ������ �� ������������
            return ��������.���������������;
        }
        [STAThread]


        static �������������� �������������������()
        {
            ����������();
            �����������();
            ������������������();
            return �����.���������������;
        }
        static void ������������������()
        {
            while (�����.�����������)
            {
                ����������������();
            }
        }
        static void ����������������()
        {
            �����.���������();
            while (�����.�������������)
            {
                �����.����();
                �����.���������();
            }
            while (�����.��������������)
            {
                �����.�����();
            }
            �����.������();
        }
        static void �����������()
        {
            �����.�����();
            �����.����();
            �����.������();
        }
        static void ����������()
        {
            ����������();
            /*while(�����.�������������)
            {
            �������();
                ����������();
            }*/
        }
        static void �������()
        {
            while (�����.������������� && �����.�������������)
            {
                �����.�����();
            }
            �����.����();
        }
        static void ����������()
        {
            while (�����.�������������)
            {
                �����.������();
            }
        }



        static void Main()
        {
            ����� = new ���������(����);
            ���� = �������������������();
            Application.Run(new �����������(����));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            �������� = new �������������(20, 15);
            ���� = ���������������������();
            Application.Run(new �����������(����));
        }
    }
}