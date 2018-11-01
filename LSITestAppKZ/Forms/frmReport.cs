using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LSITestApp.Forms
{
    public partial class frmReport : XtraForm
    {
        private readonly AppContext _appContext;

        public frmReport(AppContext appContext)
        {
            InitializeComponent();
            _appContext = appContext;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            gridReportForm.DataSource = GetData();
        }

        private void txtPlace_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty((sender as TextEdit).Text) && !int.TryParse((sender as TextEdit).Text, out int result))
                e.Cancel = true;
        }

        private IEnumerable<Export> GetData()
        {
            var exports = from ex in _appContext.Exports
                          select ex;

            if (!txtPlace.Text.IsNullEmptyOrWhiteSpace())
                //przyjąłem, że dane w kolumnie Lokal mają identyczną budowę
                exports = exports.Where(r => r.Place.Replace("Lokal ", string.Empty) == txtPlace.EditValue.ToString());

            if (dtFrom.EditValue != null)
                exports = exports.Where(r => r.Date >= (DateTime)dtFrom.EditValue);

            if (dtTo.EditValue != null)
                exports = exports.Where(r => r.Date <= (DateTime)dtTo.EditValue);

            return exports.ToList();
        }
    }
}