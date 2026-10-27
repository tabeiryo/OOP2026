using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter;
//抽象クラス
public abstract class ConverterBase
{
    //引数が自分のものか
    public abstract bool isMyUnit (string name);


    //メートルとの比率を掛けると変換
    protected abstract double Ratio { get; }

    public abstract string UnitName { get; }

    //メートルからの変換
    public double FromMeter(double meter) => meter / Ratio;

    //メートルへの変換
    public double Tometer(double feet) => feet * Ratio;
}
