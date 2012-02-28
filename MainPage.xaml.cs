using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Windows.Media.Imaging;
using System.Threading;
using System.Windows.Threading;

namespace WindowsPhoneApplication2
{
    public partial class MainPage : PhoneApplicationPage
    {
        private Uri[][] uri = new Uri[3][];
        private BitmapImage[] imgSource = new BitmapImage[9];
        private int randomNumber;
        private Random random;
        private DispatcherTimer[] dt_image = new DispatcherTimer[9];
        private Boolean[] toggle = new Boolean[9];
        public MainPage()
        {
            InitializeComponent();
            for(int i=0;i<3;i++)
            {
                uri[i] = new Uri[9];
            }
            image1.Tap += new EventHandler<GestureEventArgs>(image1_Tap);
            image2.Tap += new EventHandler<GestureEventArgs>(image2_Tap);
            image3.Tap += new EventHandler<GestureEventArgs>(image3_Tap);
            image4.Tap += new EventHandler<GestureEventArgs>(image4_Tap);
            image5.Tap += new EventHandler<GestureEventArgs>(image5_Tap);
            image6.Tap += new EventHandler<GestureEventArgs>(image6_Tap);
            image7.Tap += new EventHandler<GestureEventArgs>(image7_Tap);
            image8.Tap += new EventHandler<GestureEventArgs>(image8_Tap);
            image9.Tap += new EventHandler<GestureEventArgs>(image9_Tap);
            
            uri[0][0] = new Uri("image1_slice1.png", UriKind.Relative);
            uri[0][1] = new Uri("image1_slice2.png", UriKind.Relative);
            uri[0][2] = new Uri("image1_slice3.png", UriKind.Relative);
            uri[0][3] = new Uri("image1_slice4.png", UriKind.Relative);
            uri[0][4] = new Uri("image1_slice5.png", UriKind.Relative);
            uri[0][5] = new Uri("image1_slice6.png", UriKind.Relative);
            uri[0][6] = new Uri("image1_slice7.png", UriKind.Relative);
            uri[0][7] = new Uri("image1_slice8.png", UriKind.Relative);
            uri[0][8] = new Uri("image1_slice9.png", UriKind.Relative);
            uri[1][0] = new Uri("image2_slice1.png", UriKind.Relative);
            uri[1][1] = new Uri("image2_slice2.png", UriKind.Relative);
            uri[1][2] = new Uri("image2_slice3.png", UriKind.Relative);
            uri[1][3] = new Uri("image2_slice4.png", UriKind.Relative);
            uri[1][4] = new Uri("image2_slice5.png", UriKind.Relative);
            uri[1][5] = new Uri("image2_slice6.png", UriKind.Relative);
            uri[1][6] = new Uri("image2_slice7.png", UriKind.Relative);
            uri[1][7] = new Uri("image2_slice8.png", UriKind.Relative);
            uri[1][8] = new Uri("image2_slice9.png", UriKind.Relative);
            uri[2][0] = new Uri("image3_slice1.png", UriKind.Relative);
            uri[2][1] = new Uri("image3_slice2.png", UriKind.Relative);
            uri[2][2] = new Uri("image3_slice3.png", UriKind.Relative);
            uri[2][3] = new Uri("image3_slice4.png", UriKind.Relative);
            uri[2][4] = new Uri("image3_slice5.png", UriKind.Relative);
            uri[2][5] = new Uri("image3_slice6.png", UriKind.Relative);
            uri[2][6] = new Uri("image3_slice7.png", UriKind.Relative);
            uri[2][7] = new Uri("image3_slice8.png", UriKind.Relative);
            uri[2][8] = new Uri("image3_slice9.png", UriKind.Relative);
            
            random = new Random();
            
            randomNumber = random.Next(0, 2);
            image1.Source = new BitmapImage(uri[randomNumber][0]);
            randomNumber = random.Next(0, 2);
            image2.Source = new BitmapImage(uri[randomNumber][1]);
            randomNumber = random.Next(0, 2);
            image3.Source = new BitmapImage(uri[randomNumber][2]);
            randomNumber = random.Next(0, 2);
            image4.Source = new BitmapImage(uri[randomNumber][3]);
            randomNumber = random.Next(0, 2);
            image5.Source = new BitmapImage(uri[randomNumber][4]);
            randomNumber = random.Next(0, 2);
            image6.Source = new BitmapImage(uri[randomNumber][5]);
            randomNumber = random.Next(0, 2);
            image7.Source = new BitmapImage(uri[randomNumber][6]);
            randomNumber = random.Next(0, 2);
            image8.Source = new BitmapImage(uri[randomNumber][7]);
            randomNumber = random.Next(0, 2);
            image9.Source = new BitmapImage(uri[randomNumber][8]);
            for (int i = 0; i < 9; i++)
            {
                dt_image[i] = new DispatcherTimer();
                dt_image[i].Interval = new TimeSpan(0, 0, 0, 0, 1000); // 500 Milliseconds
            }
            dt_image[0].Tick += new EventHandler(image1Tick);
            dt_image[1].Tick += new EventHandler(image2Tick);
            dt_image[2].Tick += new EventHandler(image3Tick);
            dt_image[3].Tick += new EventHandler(image4Tick);
            dt_image[4].Tick += new EventHandler(image5Tick);
            dt_image[5].Tick += new EventHandler(image6Tick);
            dt_image[6].Tick += new EventHandler(image7Tick);
            dt_image[7].Tick += new EventHandler(image8Tick);
            dt_image[8].Tick += new EventHandler(image9Tick);
            for (int i = 0; i < 9; i++)
            {
                dt_image[i].Start();
                toggle[i] = new Boolean();
                toggle[i] = true;
            }
            
        }

        void image1Tick(object sender, EventArgs e)
        {
            random = new Random();
            randomNumber = random.Next(0, 3);
            image1.Source = new BitmapImage(uri[randomNumber][0]);
        }
        void image2Tick(object sender, EventArgs e)
        {
            random = new Random();
            randomNumber = random.Next(0, 3);
            image2.Source = new BitmapImage(uri[randomNumber][1]);
        }
        void image3Tick(object sender, EventArgs e)
        {
            random = new Random();
            randomNumber = random.Next(0, 3);
            image3.Source = new BitmapImage(uri[randomNumber][2]);
        }
        void image4Tick(object sender, EventArgs e)
        {
            random = new Random();
            randomNumber = random.Next(0, 3);
            image4.Source = new BitmapImage(uri[randomNumber][3]);
        }
        void image5Tick(object sender, EventArgs e)
        {
            random = new Random();
            randomNumber = random.Next(0, 3);
            image5.Source = new BitmapImage(uri[randomNumber][4]);
        }
        void image6Tick(object sender, EventArgs e)
        {
            random = new Random();
            randomNumber = random.Next(0, 3);
            image6.Source = new BitmapImage(uri[randomNumber][5]);
        }
        void image7Tick(object sender, EventArgs e)
        {
            random = new Random();
            randomNumber = random.Next(0, 3);
            image7.Source = new BitmapImage(uri[randomNumber][6]);
        }
        void image8Tick(object sender, EventArgs e)
        {
            random = new Random();
            randomNumber = random.Next(0, 3);
            image8.Source = new BitmapImage(uri[randomNumber][7]);
        }
        void image9Tick(object sender, EventArgs e)
        {
            random = new Random();
            randomNumber = random.Next(0, 3);
            image9.Source = new BitmapImage(uri[randomNumber][8]);
        }
        void image9_Tap(object sender, GestureEventArgs e)
        {
            if (toggle[8])
            {
                dt_image[8].Tick -= (image9Tick);
                toggle[8] = false;
            }
            else
            {
                dt_image[8].Tick += (image9Tick);
                toggle[8] = true;
            }
        }

        void image8_Tap(object sender, GestureEventArgs e)
        {
            if (toggle[7])
            {
                dt_image[7].Tick -= (image8Tick);
                toggle[7] = false;
            }
            else
            {
                dt_image[7].Tick += (image8Tick);
                toggle[7] = true;
            }
        }

        void image7_Tap(object sender, GestureEventArgs e)
        {
            if (toggle[6])
            {
                dt_image[6].Tick -= (image7Tick);
                toggle[6] = false;
            }
            else
            {
                dt_image[6].Tick += (image7Tick);
                toggle[6] = true;
            }
        }

        void image6_Tap(object sender, GestureEventArgs e)
        {
            if (toggle[5])
            {
                dt_image[5].Tick -= (image6Tick);
                toggle[5] = false;
            }
            else
            {
                dt_image[5].Tick += (image6Tick);
                toggle[5] = true;
            }
        }

        void image5_Tap(object sender, GestureEventArgs e)
        {
            if (toggle[4])
            {
                dt_image[4].Tick -= (image5Tick);
                toggle[4] = false;
            }
            else
            {
                dt_image[4].Tick += (image5Tick);
                toggle[4] = true;
            }
        }

        void image4_Tap(object sender, GestureEventArgs e)
        {
            if (toggle[3])
            {
                dt_image[3].Tick -= (image4Tick);
                toggle[3] = false;
            }
            else
            {
                dt_image[3].Tick += (image4Tick);
                toggle[3] = true;
            }
        }

        void image3_Tap(object sender, GestureEventArgs e)
        {
            if (toggle[2])
            {
                dt_image[2].Tick -= (image3Tick);
                toggle[2] = false;
            }
            else
            {
                dt_image[2].Tick += (image3Tick);
                toggle[2] = true;
            }
        }

        void image2_Tap(object sender, GestureEventArgs e)
        {
            if (toggle[1])
            {
                dt_image[1].Tick -= (image2Tick);
                toggle[1] = false;
            }
            else
            {
                dt_image[1].Tick += (image2Tick);
                toggle[1] = true;
            }
        }

        void image1_Tap(object sender, GestureEventArgs e)
        {
            if (toggle[0])
            {
                dt_image[0].Tick -= (image1Tick);
                toggle[0] = false;
            }
            else
            {
                dt_image[0].Tick += (image1Tick);
                toggle[0] = true;
            }
        }
        //private void dt_Tick(Object sender, EventArgs e)
        //{
        //    random = new Random();
        //    randomNumber = random.Next(0, 3);
        //    image1.Source = new BitmapImage(uri[randomNumber][0]);
        //    randomNumber = random.Next(0, 3);
        //    image2.Source = new BitmapImage(uri[randomNumber][1]);
        //    randomNumber = random.Next(0, 3);
        //    image3.Source = new BitmapImage(uri[randomNumber][2]);
        //    randomNumber = random.Next(0, 3);
        //    image4.Source = new BitmapImage(uri[randomNumber][3]);
        //    randomNumber = random.Next(0, 3);
        //    image5.Source = new BitmapImage(uri[randomNumber][4]);
        //    randomNumber = random.Next(0, 3);
        //    image6.Source = new BitmapImage(uri[randomNumber][5]);
        //    randomNumber = random.Next(0, 3);
        //    image7.Source = new BitmapImage(uri[randomNumber][6]);
        //    randomNumber = random.Next(0, 3);
        //    image8.Source = new BitmapImage(uri[randomNumber][7]);
        //    randomNumber = random.Next(0, 3);
        //    image9.Source = new BitmapImage(uri[randomNumber][8]);
        //}


    }
}
