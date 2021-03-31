using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface{

    [Designer(typeof(System.Windows.Forms.Design.ControlDesigner))]
    public class DataGridViewJFF : DataGridView
    {
        protected override void InitLayout()
        {
            base.InitLayout();

            //Cor de fundo das linhas
            this.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(184, 204, 228);

            //Cor do texto
            this.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);

            //Cor de fundo das linhas alternadas
            this.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(219, 229, 241);

            //Cor do texto das linhas alternadas
            this.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0);

            //Cor de fundo da linha selecionada
            this.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(78, 129, 189);

            //Cor do texto da linha selecionada
            this.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255);

            //Cor de fundo do DataGridView (parte sem nenhuma informação)
            this.BackgroundColor = System.Drawing.Color.FromArgb(220, 220, 220);

            //Gosto de deixar o modo de seleção como FullRowSelect, desta forma ao clicar em uma célula a linha inteira é marcada
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
