using SrvMan.Presentation.Models;
using SrvMan.Presentation.ViewModels;

namespace SrvMan.Presentation.Windows
{
    /// <summary>
    /// Interaction logic for CreateOrEditServiceWindow.xaml
    /// </summary>
    public partial class CreateOrEditServiceWindow
    {
        /// <summary>
        /// Data context object.
        /// </summary>
        public CreateOrEditServiceWindowViewModel Context { get; }

        /// <summary>
        /// Constructor for <see cref="CreateOrEditServiceWindow"/>.
        /// </summary>
        public CreateOrEditServiceWindow() : this(null)
        {

        }

        /// <summary>
        /// Constructor for <see cref="CreateOrEditServiceWindow"/>.
        /// </summary>
        public CreateOrEditServiceWindow(ServiceModel serviceModel)
        {
            DataContext = Context = new CreateOrEditServiceWindowViewModel(serviceModel);
            InitializeComponent();
        }
    }
}