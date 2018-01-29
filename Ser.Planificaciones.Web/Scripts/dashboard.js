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

            //self.navbars.topBar.Rights = ko.purecomputed(function (right) {                /// <summary>
                /// 
                /// </summary>
                /// <param name="right) {"></param>    //
            //});
        }

        self.content = ko.observableArray(navbar.content || []);
        self.content = function Link(link) {

            self.id = ko.observable(link.id || '');
            self.class = ko.observable(link.class || '');
            self.kO = ko.observable(link.kO || '');
            self.href = ko.observable(link.href || '');
            self.active = ko.observable(link.active || '');
        }
    }

}
