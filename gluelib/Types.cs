using System.Collections.Generic;

namespace GLUELib.Types;

// ASCII type
public class A : GLUEType
{
  private readonly string _value;

  private A(string value)
  {
    _value = value;
  }

  public static implicit operator A(string value)
  {
    return new A(value);
  }

  public static implicit operator string(A gtype)
  {
    return gtype._value;
  }

  public override string ToString()
  {
    return $"A:{Length()}(\"{_value}\")";
  }

  public int Length()
  {
    return _value.Length;
  }
}

// Binary type
public class B : GLUEType
{
  private readonly byte[] _value;

  private B(byte[] value)
  {
    _value = value;
  }

  public static implicit operator B(byte[] value)
  {
    return new B(value);
  }

  public static implicit operator B(byte value)
  {
    return new B([value]);
  }

  public static implicit operator byte[](B gtype)
  {
    return gtype._value;
  }

  public static implicit operator byte(B gtype)
  {
    return gtype._value[0];
  }

  public override string ToString()
  {
    return $"B:{Length()}({string.Join(",", _value.Select(v => $"0x{v:X2}"))})";
  }

  public int Length()
  {
    return _value.Length;
  }
}

// 4-byte float type
public class F4 : GLUEType
{
  private readonly float[] _value;

  private F4(float[] value)
  {
    _value = value;
  }

  public static implicit operator F4(float[] value)
  {
    return new F4(value);
  }

  public static implicit operator F4(float value)
  {
    return new F4([value]);
  }

  public static implicit operator float[](F4 gtype)
  {
    return gtype._value;
  }

  public static implicit operator float(F4 gtype)
  {
    return gtype._value[0];
  }

  public override string ToString()
  {
    return $"F4:{Length()}({string.Join(",", _value)})";
  }

  public int Length()
  {
    return _value.Length;
  }
}

// 8-byte float type
public class F8 : GLUEType
{
  private readonly double[] _value;

  private F8(double[] value)
  {
    _value = value;
  }

  public static implicit operator F8(double[] value)
  {
    return new F8(value);
  }

  public static implicit operator F8(double value)
  {
    return new F8([value]);
  }

  public static implicit operator double[](F8 gtype)
  {
    return gtype._value;
  }

  public static implicit operator double(F8 gtype)
  {
    return gtype._value[0];
  }

  public override string ToString()
  {
    return $"F8:{Length()}({string.Join(",", _value)})";
  }

  public int Length()
  {
    return _value.Length;
  }
}

// 1-byte signed integer type
public class I1 : GLUEType
{
  private readonly sbyte[] _value;

  private I1(sbyte[] value)
  {
    _value = value;
  }

  public static implicit operator I1(sbyte[] value)
  {
    return new I1(value);
  }

  public static implicit operator I1(sbyte value)
  {
    return new I1([value]);
  }

  public static implicit operator sbyte[](I1 gtype)
  {
    return gtype._value;
  }

  public static implicit operator sbyte(I1 gtype)
  {
    return gtype._value[0];
  }

  public override string ToString()
  {
    return $"I1:{Length()}({_value})";
  }

  public int Length()
  {
    return _value.Length;
  }
}

// 2-byte signed integer type
public class I2 : GLUEType
{
  private readonly short[] _value;

  private I2(short[] value)
  {
    _value = value;
  }

  public static implicit operator I2(short[] value)
  {
    return new I2(value);
  }

  public static implicit operator I2(short value)
  {
    return new I2([value]);
  }

  public static implicit operator short[](I2 gtype)
  {
    return gtype._value;
  }

  public static implicit operator short(I2 gtype)
  {
    return gtype._value[0];
  }

  public override string ToString()
  {
    return $"I2:{Length()}({string.Join(",", _value)})";
  }

  public int Length()
  {
    return _value.Length;
  }
}

// 4-byte signed integer type
public class I4 : GLUEType
{
  private readonly int[] _value;

  private I4(int[] value)
  {
    _value = value;
  }

  public static implicit operator I4(int[] value)
  {
    return new I4(value);
  }

  public static implicit operator I4(int value)
  {
    return new I4([value]);
  }

  public static implicit operator int[](I4 gtype)
  {
    return gtype._value;
  }

  public static implicit operator int(I4 gtype)
  {
    return gtype._value[0];
  }

  public override string ToString()
  {
    return $"I4:{Length()}({string.Join(",", _value)})";
  }

  public int Length()
  {
    return _value.Length;
  }
}

// 8-byte signed integer type
public class I8 : GLUEType
{
  private readonly long[] _value;

  private I8(long[] value)
  {
    _value = value;
  }

  public static implicit operator I8(long[] value)
  {
    return new I8(value);
  }

  public static implicit operator I8(long value)
  {
    return new I8([value]);
  }

  public static implicit operator long[](I8 gtype)
  {
    return gtype._value;
  }

  public static implicit operator long(I8 gtype)
  {
    return gtype._value[0];
  }

  public override string ToString()
  {
    return $"I8:{Length()}({string.Join(",", _value)})";
  }

  public int Length()
  {
    return _value.Length;
  }
}

// List type
public class L : GLUEType
{
  private readonly List<GLUEType> _list;

  private L(List<GLUEType> list)
  {
    _list = list;
  }

  public static implicit operator L(List<GLUEType> list)
  {
    return new L(list);
  }

  public static implicit operator List<GLUEType>(L gtype)
  {
    return gtype._list;
  }

  public override string ToString()
  {
    return $"L:{Length()}({string.Join(",", _list.ConvertAll<string>(v => v.ToString()!))})";
  }

  public int Length()
  {
    return _list.Count;
  }
}

// Boolean type
public class TF : GLUEType
{
  private readonly bool[] _value;

  private TF(bool[] value)
  {
    _value = value;
  }

  public static implicit operator TF(bool[] value)
  {
    return new TF(value);
  }

  public static implicit operator TF(bool value)
  {
    return new TF([value]);
  }

  public static implicit operator bool[](TF gtype)
  {
    return gtype._value;
  }

  public static implicit operator bool(TF gtype)
  {
    return gtype._value[0];
  }

  public override string ToString()
  {
    return $"TF:{Length()}({string.Join(",", _value)})";
  }

  public int Length()
  {
    return _value.Length;
  }
}

// 1-byte unsigned integer
public class U1 : GLUEType
{
  private readonly byte[] _value;

  private U1(byte[] value)
  {
    _value = value;
  }

  public static implicit operator U1(byte[] value)
  {
    return new U1(value);
  }

  public static implicit operator U1(byte value)
  {
    return new U1([value]);
  }

  public static implicit operator byte[](U1 gtype)
  {
    return gtype._value;
  }

  public static implicit operator byte(U1 gtype)
  {
    return gtype._value[0];
  }

  public override string ToString()
  {
    return $"U1:{Length()}({string.Join(",", _value)})";
  }

  public int Length()
  {
    return _value.Length;
  }
}

// 2-byte unsigned integer
public class U2 : GLUEType
{
  private readonly ushort[] _value;

  private U2(ushort[] value)
  {
    _value = value;
  }

  public static implicit operator U2(ushort[] value)
  {
    return new U2(value);
  }

  public static implicit operator U2(ushort value)
  {
    return new U2([value]);
  }

  public static implicit operator ushort[](U2 gtype)
  {
    return gtype._value;
  }

  public static implicit operator ushort(U2 gtype)
  {
    return gtype._value[0];
  }

  public override string ToString()
  {
    return $"U2:{Length()}({string.Join(",", _value)})";
  }

  public int Length()
  {
    return _value.Length;
  }
}

// 4-byte unsigned integer
public class U4 : GLUEType
{
  private readonly uint[] _value;

  private U4(uint[] value)
  {
    _value = value;
  }

  public static implicit operator U4(uint[] value)
  {
    return new U4(value);
  }

  public static implicit operator U4(uint value)
  {
    return new U4([value]);
  }

  public static implicit operator uint[](U4 gtype)
  {
    return gtype._value;
  }

  public static implicit operator uint(U4 gtype)
  {
    return gtype._value[0];
  }

  public override string ToString()
  {
    return $"U4:{Length()}({string.Join(",", _value)})";
  }

  public int Length()
  {
    return _value.Length;
  }
}

// 8-byte unsigned integer
public class U8 : GLUEType
{
  private readonly ulong[] _value;

  private U8(ulong[] value)
  {
    _value = value;
  }

  public static implicit operator U8(ulong[] value)
  {
    return new U8(value);
  }

  public static implicit operator U8(ulong value)
  {
    return new U8([value]);
  }

  public static implicit operator ulong[](U8 gtype)
  {
    return gtype._value;
  }

  public static implicit operator ulong(U8 gtype)
  {
    return gtype._value[0];
  }

  public override string ToString()
  {
    return $"U8:{Length()}({string.Join(",", _value)})";
  }

  public int Length()
  {
    return _value.Length;
  }
}
