using PageObjectTest.Helper;
using PageObjectTest.Page;

namespace PageObjectTest
{
    public class Tests:Base
    {
        PraticeForm form;
        

        [Test]
        public void Test1()
        {
            form = new PraticeForm();
            form.EnterName("Marko");
            form.EnterLastName("Manojlovic");
            form.EnterEmail("manojlovicm1510@gmail.com");
            form.SelectGender();
            form.EnterMobileNumber("2131231");
            form.EnterSubjcet("Maths");
            form.SelectHobbis();
            form.Button.Submit();
        }
    }
}