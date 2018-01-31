function DashboardViewModel(dashboardViewModel) {
    /// <param name="dashboardViewModel">Movel with values [Json]</param>

    var self = this;

    /// title of page dashboard
    self.Title = ko.observable(self.Title);

    self.navbars = function Navbar(navbar) {
        /// <summary>
        /// Contiene info. sobre las diferentes tipos de barras de
        /// navegación que hay en el dashboard
        /// </summary>
        /// <param name="navbar" type="Navbar"></param>

        self.navbars.topBar = function Topbar(topbar) {
            /// <summary>
            /// Info. de la barra superior donde aparece
            /// el nombre de la compañía y la lista derecha
            /// </summary>
            /// <param name="topbar" type="Topbar"></param>
            self.navbars.topBar.companyName = ko.observable(self.navbars.topBar.companyName || '');

            self.navbars.topBar.Links = ko.observableArray(self.navbars.topBar.Links || [])

            self.navbars.topBar.Rights = ko.observableArray(self.navbars.topBar.Rights || [])
            self.navbars.topBar.Rights = function Rights(link) {

                self.Id = ko.observable(link.Id || '');
                self.Class = ko.observable(link.Class || '');
                self.Text = ko.observable(link.Text || '');
                self.Href = ko.observable(link.Href || '');
                self.Active = ko.observable(link.Active || '');
            };

            self.navbars.Content = ko.observableArray(navbar.navbars.Content || []);
            self.navbars.Content = function Content(link) {

                self.Id = ko.observable(link.Id || '');
                self.Class = ko.observable(link.Class || '');
                self.Text = ko.observable(link.Text || '');
                self.Href = ko.observable(link.Href || '');
                self.Active = ko.observable(link.Active || '');
            }
        }
    }
}
