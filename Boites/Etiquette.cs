using System;
using System.Collections.Generic;
using System.Text;

namespace Boites

{
    public enum Formats { XS, S, M, L, XL };

    class Etiquette
    {
    public string Text { get; set; }
    public Couleurs Couleur { get; set; }
    public Formats Format { get; set; }
}
}
