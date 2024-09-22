using k8s;

namespace Sextant.Maui
{
    public partial class App : Application
    {
        public static Kubernetes? Kubernetes { get; set; }
        public App()
        {
            InitializeComponent();
            var config = KubernetesClientConfiguration.BuildDefaultConfig();
            Kubernetes = new Kubernetes(config);
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}
