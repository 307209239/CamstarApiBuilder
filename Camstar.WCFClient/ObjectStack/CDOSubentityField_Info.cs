// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CDOSubentityField_Info
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
  public class CDOSubentityField_Info : CDOField_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_Info_AField4")]
    protected CDOField_Info _AField4;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_Info_AField24")]
    protected CDOField_Info _AField24;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_Info_AField13")]
    protected CDOField_Info _AField13;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_Info_AField30")]
    protected CDOField_Info _AField30;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_Info_AField0")]
    protected CDOField_Info _AField0;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_Info_AField38")]
    protected CDOField_Info _AField38;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_Info_AField11")]
    protected CDOField_Info _AField11;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_Info_AField27")]
    protected CDOField_Info _AField27;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_Info_AField39")]
    protected CDOField_Info _AField39;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_Info_AField31")]
    protected CDOField_Info _AField31;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_Info_AField28")]
    protected CDOField_Info _AField28;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_Info_AField33")]
    protected CDOField_Info _AField33;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_Info_AField34")]
    protected CDOField_Info _AField34;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_Info_AField32")]
    protected CDOField_Info _AField32;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_Info_AField37")]
    protected CDOField_Info _AField37;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_Info_AField25")]
    protected CDOField_Info _AField25;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_Info_AField19")]
    protected CDOField_Info _AField19;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_Info_AField29")]
    protected CDOField_Info _AField29;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_Info_AField16")]
    protected CDOField_Info _AField16;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_Info_AField26")]
    protected CDOField_Info _AField26;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_Info_AField22")]
    protected CDOField_Info _AField22;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_Info_AField21")]
    protected CDOField_Info _AField21;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_Info_AField15")]
    protected CDOField_Info _AField15;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_Info_AField17")]
    protected CDOField_Info _AField17;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_Info_AField18")]
    protected CDOField_Info _AField18;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_Info_AField14")]
    protected CDOField_Info _AField14;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_Info_AField20")]
    protected CDOField_Info _AField20;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_Info_AField8")]
    protected CDOField_Info _AField8;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_Info_AField36")]
    protected CDOField_Info _AField36;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_Info_AField9")]
    protected CDOField_Info _AField9;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_Info_AField6")]
    protected CDOField_Info _AField6;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_Info_AField10")]
    protected CDOField_Info _AField10;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_Info_AField1")]
    protected CDOField_Info _AField1;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_Info_AField2")]
    protected CDOField_Info _AField2;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_Info_AField3")]
    protected CDOField_Info _AField3;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_Info_AField7")]
    protected CDOField_Info _AField7;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_Info_AField35")]
    protected CDOField_Info _AField35;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_Info_AField23")]
    protected CDOField_Info _AField23;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_Info_AField12")]
    protected CDOField_Info _AField12;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_Info_AField5")]
    protected CDOField_Info _AField5;
    [DataMember(EmitDefaultValue = false, Name = "CDOSubentityField_Info_FieldCount")]
    protected Info _FieldCount;

    public CDOField_Info AField4
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField4), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (AField4));
      }
    }

    public CDOField_Info AField24
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField24), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (AField24));
      }
    }

    public CDOField_Info AField13
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField13), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (AField13));
      }
    }

    public CDOField_Info AField30
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField30), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (AField30));
      }
    }

    public CDOField_Info AField0
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField0), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (AField0));
      }
    }

    public CDOField_Info AField38
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField38), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (AField38));
      }
    }

    public CDOField_Info AField11
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField11), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (AField11));
      }
    }

    public CDOField_Info AField27
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField27), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (AField27));
      }
    }

    public CDOField_Info AField39
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField39), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (AField39));
      }
    }

    public CDOField_Info AField31
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField31), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (AField31));
      }
    }

    public CDOField_Info AField28
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField28), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (AField28));
      }
    }

    public CDOField_Info AField33
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField33), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (AField33));
      }
    }

    public CDOField_Info AField34
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField34), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (AField34));
      }
    }

    public CDOField_Info AField32
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField32), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (AField32));
      }
    }

    public CDOField_Info AField37
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField37), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (AField37));
      }
    }

    public CDOField_Info AField25
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField25), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (AField25));
      }
    }

    public CDOField_Info AField19
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField19), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (AField19));
      }
    }

    public CDOField_Info AField29
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField29), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (AField29));
      }
    }

    public CDOField_Info AField16
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField16), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (AField16));
      }
    }

    public CDOField_Info AField26
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField26), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (AField26));
      }
    }

    public CDOField_Info AField22
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField22), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (AField22));
      }
    }

    public CDOField_Info AField21
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField21), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (AField21));
      }
    }

    public CDOField_Info AField15
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField15), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (AField15));
      }
    }

    public CDOField_Info AField17
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField17), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (AField17));
      }
    }

    public CDOField_Info AField18
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField18), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (AField18));
      }
    }

    public CDOField_Info AField14
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField14), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (AField14));
      }
    }

    public CDOField_Info AField20
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField20), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (AField20));
      }
    }

    public CDOField_Info AField8
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField8), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (AField8));
      }
    }

    public CDOField_Info AField36
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField36), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (AField36));
      }
    }

    public CDOField_Info AField9
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField9), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (AField9));
      }
    }

    public CDOField_Info AField6
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField6), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (AField6));
      }
    }

    public CDOField_Info AField10
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField10), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (AField10));
      }
    }

    public CDOField_Info AField1
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField1), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (AField1));
      }
    }

    public CDOField_Info AField2
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField2), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (AField2));
      }
    }

    public CDOField_Info AField3
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField3), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (AField3));
      }
    }

    public CDOField_Info AField7
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField7), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (AField7));
      }
    }

    public CDOField_Info AField35
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField35), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (AField35));
      }
    }

    public CDOField_Info AField23
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField23), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (AField23));
      }
    }

    public CDOField_Info AField12
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField12), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (AField12));
      }
    }

    public CDOField_Info AField5
    {
      [param: In] set
      {
        this.PropertySet(nameof (AField5), (object) value);
      }
      get
      {
        return (CDOField_Info) this.PropertyGet(nameof (AField5));
      }
    }

    public Info FieldCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (FieldCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FieldCount));
      }
    }
  }
}
