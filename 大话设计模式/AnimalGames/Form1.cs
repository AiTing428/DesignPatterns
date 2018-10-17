using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

/*=============================知识点===================================
 * ✿✿ 集合：
 *   1、ArrayList：
 *          ArrayList的命名空间是System.Collections;他是使用大小可按需动态增加的数组实现IList接口
 *          ArrayList的容量是ArrayList可以保存的元素数。ArrayList的默认初始容量为0.随着元素添加到ArrayList中，容量会根据需要通过重新分配自动增加。使用整数索引可以访问此集合中的元素。此集合中的索引从零开始。
 *          
 *          
 * 
 * ✿✿ 装箱，拆箱：
 *    装箱就是把值类型打包到Object引用类型的一个实例中 ex:整形变量i被“装箱”并赋值给对象o
 *          int i = 123;
            object o = (object)i;
      拆箱就是指从对象中提取值类型。ex：对象o拆箱并将其赋值给整形变量i
 *          o = 213;
            i = (int)o;
 *    相对于简单的赋值而言，装箱和拆箱过程需要进行大量的计算。对值类型进行装箱时，必须分配并构造一个全新的对象。其次，拆箱所需的强制转换也需要进行大量的计算。
 *    
 *    
 * ✿✿ 泛型：
 *      泛型的命名空间是System.Collections.Generic
 *      泛型是具有占位符（类型参数）的类、结构、接口和方法，这些占位符是类、接口、结构和方法所存储或使用的一个或多个类型的占位符。泛型集合类可以将类型参数用作它所存储的对象的类型的占位符；类型参数作为其字段的类型和其方法的参数类型出现。
 * 
 * 
 * 
 * 
 ===================================================================*/


namespace AnimalGames
{
    public partial class Form1 : Form
    {

        //private Animal[] arrayAnimal;
        //声明一集合变量，可以用接口IList，也可以直接声明 ArrayList arrayAnimal
        //IList arrayAnimal;

        // 集合变量只能接受Animal类型
        IList<Animal> arrayAnimal;


        public Form1()
        {
            InitializeComponent();
        }

        private void CatBtn_Click(object sender, EventArgs e)
        {
            Cat cat = new Cat("咪咪");
            cat.ShoutNum = 7;
            MessageBox.Show(cat.Shout());
        }

        private void DogBtn_Click(object sender, EventArgs e)
        {
            Dog dog = new Dog("旺财");
            dog.ShoutNum = 5;
            MessageBox.Show(dog.Shout());
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            //实例化ArrayList对象，注意，此时并没有指定arrayAnimal的大小，这与数组并不相同
            //arrayAnimal = new ArrayList();
            
            arrayAnimal = new List<Animal>();

            //调用集合的Add方法增加对象，其参数是object，所有new Cat和New Dog都没问题
            arrayAnimal.Add(new Cat("小花"));
            arrayAnimal.Add(new Dog("阿毛"));
            arrayAnimal.Add(new Dog("小黑"));
            arrayAnimal.Add(new Cat("娇娇"));
            arrayAnimal.Add(new Cat("咪咪"));


            arrayAnimal.RemoveAt(4);    //移除

            MessageBox.Show(arrayAnimal.Count.ToString());  //当前数组的元素个数

        }

        private void BeginBtn_Click(object sender, EventArgs e)
        {
            foreach (Animal item in arrayAnimal)
            {
                MessageBox.Show(item.Shout());
            }
        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            Doraemon Dcat = new Doraemon("哆啦A梦");
            SunWukong sunWuKong = new SunWukong("孙悟空");

            //什么一个接口数组，将两个类实例赋值给数组
            IChange[] array = new IChange[2];
            array[0] = Dcat;
            array[1] = sunWuKong;

            MessageBox.Show(array[0].ChangeThing("好多好多东西！"));
            MessageBox.Show(array[1].ChangeThing("各种各样的东西！"));
        }
    }
}
