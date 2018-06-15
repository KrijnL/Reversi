using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace View
{
    /// <summary>
    /// Interaction logic for ScoreBar.xaml
    /// </summary>
    public partial class ScoreBar : UserControl
    {

        public int Maximum
        {
            get
            {
                return BoardWidth * BoardHeight;
            }
        }

        public int BoardWidth
        {
            get
            {
                return (int)GetValue(BoardWidthProperty);
            }
            set
            {
                SetValue(BoardWidthProperty, value);
            }
        }
        public int BoardHeight
        {
            get
            {
                return (int)GetValue(BoardHeightProperty);
            }
            set
            {
                SetValue(BoardHeightProperty, value);
            }
        }

        public int Score
        {
            get
            {
                return (int)GetValue(ScoreProperty);
            }
            set
            {
                SetValue(ScoreProperty, value);
            }
        }

        public static readonly DependencyProperty BoardWidthProperty = DependencyProperty.Register("BoardWidth", typeof(int), typeof(ScoreBar), new PropertyMetadata(null));
        public static readonly DependencyProperty BoardHeightProperty = DependencyProperty.Register("BoardHeight", typeof(int), typeof(ScoreBar), new PropertyMetadata(null));
        public static readonly DependencyProperty ScoreProperty = DependencyProperty.Register("Score", typeof(int), typeof(ScoreBar), new PropertyMetadata(null));

        public ScoreBar()
        {
            InitializeComponent();

            LayoutRoot.DataContext = this;
        }
    }
}
