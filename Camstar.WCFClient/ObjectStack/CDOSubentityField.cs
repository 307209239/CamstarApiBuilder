// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CDOSubentityField
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class CDOSubentityField : CDOField
  {
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_AField4")]
    protected CDOField _AField4;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_AField24")]
    protected CDOField _AField24;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_AField13")]
    protected CDOField _AField13;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_AField30")]
    protected CDOField _AField30;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_AField0")]
    protected CDOField _AField0;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_AField38")]
    protected CDOField _AField38;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_AField11")]
    protected CDOField _AField11;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_AField27")]
    protected CDOField _AField27;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_AField39")]
    protected CDOField _AField39;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_AField31")]
    protected CDOField _AField31;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_AField28")]
    protected CDOField _AField28;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_AField33")]
    protected CDOField _AField33;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_AField34")]
    protected CDOField _AField34;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_AField32")]
    protected CDOField _AField32;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_AField37")]
    protected CDOField _AField37;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_AField25")]
    protected CDOField _AField25;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_AField19")]
    protected CDOField _AField19;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_AField29")]
    protected CDOField _AField29;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_AField16")]
    protected CDOField _AField16;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_AField26")]
    protected CDOField _AField26;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_AField22")]
    protected CDOField _AField22;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_AField21")]
    protected CDOField _AField21;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_AField15")]
    protected CDOField _AField15;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_AField17")]
    protected CDOField _AField17;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_AField18")]
    protected CDOField _AField18;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_AField14")]
    protected CDOField _AField14;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_AField20")]
    protected CDOField _AField20;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_AField8")]
    protected CDOField _AField8;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_AField36")]
    protected CDOField _AField36;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_AField9")]
    protected CDOField _AField9;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_AField6")]
    protected CDOField _AField6;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_AField10")]
    protected CDOField _AField10;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_AField1")]
    protected CDOField _AField1;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_AField2")]
    protected CDOField _AField2;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_AField3")]
    protected CDOField _AField3;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_AField7")]
    protected CDOField _AField7;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_AField35")]
    protected CDOField _AField35;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_AField23")]
    protected CDOField _AField23;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_AField12")]
    protected CDOField _AField12;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_AField5")]
    protected CDOField _AField5;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_FieldCount")]
    protected Primitive<int> _FieldCount;

    public override bool Equals(object obj)
    {
      return obj is CDOSubentityField && object.Equals((object) this._AField4, (object) ((CDOSubentityField) obj)._AField4) && (object.Equals((object) this._AField24, (object) ((CDOSubentityField) obj)._AField24) && object.Equals((object) this._AField13, (object) ((CDOSubentityField) obj)._AField13)) && (object.Equals((object) this._AField30, (object) ((CDOSubentityField) obj)._AField30) && object.Equals((object) this._AField0, (object) ((CDOSubentityField) obj)._AField0) && (object.Equals((object) this._AField38, (object) ((CDOSubentityField) obj)._AField38) && object.Equals((object) this._AField11, (object) ((CDOSubentityField) obj)._AField11))) && (object.Equals((object) this._AField27, (object) ((CDOSubentityField) obj)._AField27) && object.Equals((object) this._AField39, (object) ((CDOSubentityField) obj)._AField39) && (object.Equals((object) this._AField31, (object) ((CDOSubentityField) obj)._AField31) && object.Equals((object) this._AField28, (object) ((CDOSubentityField) obj)._AField28)) && (object.Equals((object) this._AField33, (object) ((CDOSubentityField) obj)._AField33) && object.Equals((object) this._AField34, (object) ((CDOSubentityField) obj)._AField34) && (object.Equals((object) this._AField32, (object) ((CDOSubentityField) obj)._AField32) && object.Equals((object) this._AField37, (object) ((CDOSubentityField) obj)._AField37)))) && (object.Equals((object) this._AField25, (object) ((CDOSubentityField) obj)._AField25) && object.Equals((object) this._AField19, (object) ((CDOSubentityField) obj)._AField19) && (object.Equals((object) this._AField29, (object) ((CDOSubentityField) obj)._AField29) && object.Equals((object) this._AField16, (object) ((CDOSubentityField) obj)._AField16)) && (object.Equals((object) this._AField26, (object) ((CDOSubentityField) obj)._AField26) && object.Equals((object) this._AField22, (object) ((CDOSubentityField) obj)._AField22) && (object.Equals((object) this._AField21, (object) ((CDOSubentityField) obj)._AField21) && object.Equals((object) this._AField15, (object) ((CDOSubentityField) obj)._AField15))) && (object.Equals((object) this._AField17, (object) ((CDOSubentityField) obj)._AField17) && object.Equals((object) this._AField18, (object) ((CDOSubentityField) obj)._AField18) && (object.Equals((object) this._AField14, (object) ((CDOSubentityField) obj)._AField14) && object.Equals((object) this._AField20, (object) ((CDOSubentityField) obj)._AField20)) && (object.Equals((object) this._AField8, (object) ((CDOSubentityField) obj)._AField8) && object.Equals((object) this._AField36, (object) ((CDOSubentityField) obj)._AField36) && (object.Equals((object) this._AField9, (object) ((CDOSubentityField) obj)._AField9) && object.Equals((object) this._AField6, (object) ((CDOSubentityField) obj)._AField6))))) && (object.Equals((object) this._AField10, (object) ((CDOSubentityField) obj)._AField10) && object.Equals((object) this._AField1, (object) ((CDOSubentityField) obj)._AField1) && (object.Equals((object) this._AField2, (object) ((CDOSubentityField) obj)._AField2) && object.Equals((object) this._AField3, (object) ((CDOSubentityField) obj)._AField3)) && (object.Equals((object) this._AField7, (object) ((CDOSubentityField) obj)._AField7) && object.Equals((object) this._AField35, (object) ((CDOSubentityField) obj)._AField35) && (object.Equals((object) this._AField23, (object) ((CDOSubentityField) obj)._AField23) && object.Equals((object) this._AField12, (object) ((CDOSubentityField) obj)._AField12))) && (object.Equals((object) this._AField5, (object) ((CDOSubentityField) obj)._AField5) && object.Equals((object) this._FieldCount, (object) ((CDOSubentityField) obj)._FieldCount))) && base.Equals(obj);
    }

    public CDOField AField4
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField4), (object) value);
      }
      get
      {
        return (CDOField) this.PropertyGet(nameof (AField4));
      }
    }

    public CDOField AField24
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField24), (object) value);
      }
      get
      {
        return (CDOField) this.PropertyGet(nameof (AField24));
      }
    }

    public CDOField AField13
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField13), (object) value);
      }
      get
      {
        return (CDOField) this.PropertyGet(nameof (AField13));
      }
    }

    public CDOField AField30
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField30), (object) value);
      }
      get
      {
        return (CDOField) this.PropertyGet(nameof (AField30));
      }
    }

    public CDOField AField0
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField0), (object) value);
      }
      get
      {
        return (CDOField) this.PropertyGet(nameof (AField0));
      }
    }

    public CDOField AField38
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField38), (object) value);
      }
      get
      {
        return (CDOField) this.PropertyGet(nameof (AField38));
      }
    }

    public CDOField AField11
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField11), (object) value);
      }
      get
      {
        return (CDOField) this.PropertyGet(nameof (AField11));
      }
    }

    public CDOField AField27
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField27), (object) value);
      }
      get
      {
        return (CDOField) this.PropertyGet(nameof (AField27));
      }
    }

    public CDOField AField39
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField39), (object) value);
      }
      get
      {
        return (CDOField) this.PropertyGet(nameof (AField39));
      }
    }

    public CDOField AField31
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField31), (object) value);
      }
      get
      {
        return (CDOField) this.PropertyGet(nameof (AField31));
      }
    }

    public CDOField AField28
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField28), (object) value);
      }
      get
      {
        return (CDOField) this.PropertyGet(nameof (AField28));
      }
    }

    public CDOField AField33
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField33), (object) value);
      }
      get
      {
        return (CDOField) this.PropertyGet(nameof (AField33));
      }
    }

    public CDOField AField34
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField34), (object) value);
      }
      get
      {
        return (CDOField) this.PropertyGet(nameof (AField34));
      }
    }

    public CDOField AField32
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField32), (object) value);
      }
      get
      {
        return (CDOField) this.PropertyGet(nameof (AField32));
      }
    }

    public CDOField AField37
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField37), (object) value);
      }
      get
      {
        return (CDOField) this.PropertyGet(nameof (AField37));
      }
    }

    public CDOField AField25
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField25), (object) value);
      }
      get
      {
        return (CDOField) this.PropertyGet(nameof (AField25));
      }
    }

    public CDOField AField19
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField19), (object) value);
      }
      get
      {
        return (CDOField) this.PropertyGet(nameof (AField19));
      }
    }

    public CDOField AField29
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField29), (object) value);
      }
      get
      {
        return (CDOField) this.PropertyGet(nameof (AField29));
      }
    }

    public CDOField AField16
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField16), (object) value);
      }
      get
      {
        return (CDOField) this.PropertyGet(nameof (AField16));
      }
    }

    public CDOField AField26
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField26), (object) value);
      }
      get
      {
        return (CDOField) this.PropertyGet(nameof (AField26));
      }
    }

    public CDOField AField22
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField22), (object) value);
      }
      get
      {
        return (CDOField) this.PropertyGet(nameof (AField22));
      }
    }

    public CDOField AField21
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField21), (object) value);
      }
      get
      {
        return (CDOField) this.PropertyGet(nameof (AField21));
      }
    }

    public CDOField AField15
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField15), (object) value);
      }
      get
      {
        return (CDOField) this.PropertyGet(nameof (AField15));
      }
    }

    public CDOField AField17
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField17), (object) value);
      }
      get
      {
        return (CDOField) this.PropertyGet(nameof (AField17));
      }
    }

    public CDOField AField18
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField18), (object) value);
      }
      get
      {
        return (CDOField) this.PropertyGet(nameof (AField18));
      }
    }

    public CDOField AField14
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField14), (object) value);
      }
      get
      {
        return (CDOField) this.PropertyGet(nameof (AField14));
      }
    }

    public CDOField AField20
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField20), (object) value);
      }
      get
      {
        return (CDOField) this.PropertyGet(nameof (AField20));
      }
    }

    public CDOField AField8
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField8), (object) value);
      }
      get
      {
        return (CDOField) this.PropertyGet(nameof (AField8));
      }
    }

    public CDOField AField36
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField36), (object) value);
      }
      get
      {
        return (CDOField) this.PropertyGet(nameof (AField36));
      }
    }

    public CDOField AField9
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField9), (object) value);
      }
      get
      {
        return (CDOField) this.PropertyGet(nameof (AField9));
      }
    }

    public CDOField AField6
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField6), (object) value);
      }
      get
      {
        return (CDOField) this.PropertyGet(nameof (AField6));
      }
    }

    public CDOField AField10
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField10), (object) value);
      }
      get
      {
        return (CDOField) this.PropertyGet(nameof (AField10));
      }
    }

    public CDOField AField1
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField1), (object) value);
      }
      get
      {
        return (CDOField) this.PropertyGet(nameof (AField1));
      }
    }

    public CDOField AField2
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField2), (object) value);
      }
      get
      {
        return (CDOField) this.PropertyGet(nameof (AField2));
      }
    }

    public CDOField AField3
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField3), (object) value);
      }
      get
      {
        return (CDOField) this.PropertyGet(nameof (AField3));
      }
    }

    public CDOField AField7
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField7), (object) value);
      }
      get
      {
        return (CDOField) this.PropertyGet(nameof (AField7));
      }
    }

    public CDOField AField35
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField35), (object) value);
      }
      get
      {
        return (CDOField) this.PropertyGet(nameof (AField35));
      }
    }

    public CDOField AField23
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField23), (object) value);
      }
      get
      {
        return (CDOField) this.PropertyGet(nameof (AField23));
      }
    }

    public CDOField AField12
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField12), (object) value);
      }
      get
      {
        return (CDOField) this.PropertyGet(nameof (AField12));
      }
    }

    public CDOField AField5
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField5), (object) value);
      }
      get
      {
        return (CDOField) this.PropertyGet(nameof (AField5));
      }
    }

    public Primitive<int> FieldCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (FieldCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (FieldCount));
      }
    }
  }
}
