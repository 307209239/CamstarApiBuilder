// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserDataCollectionDefChanges_Info
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
  public class UserDataCollectionDefChanges_Info : DataCollectionDefChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UserDataCollectionDefChanges_Info_DataPoints")]
    protected DataPointChanges_Info _DataPoints;
    [DataMember(EmitDefaultValue = false, Name = "UserDataCollectionDefChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UserDataCollectionDefChanges_Info_Base")]
    protected new Info _Base;
    [DataMember(EmitDefaultValue = false, Name = "UserDataCollectionDefChanges_Info_DataPointLayout")]
    protected Info _DataPointLayout;
    [DataMember(EmitDefaultValue = false, Name = "UserDataCollectionDefChanges_Info_ParametricDataDefType")]
    protected new Info _ParametricDataDefType;
    [DataMember(EmitDefaultValue = false, Name = "UserDataCollectionDefChanges_Info_DisplayLimits")]
    protected Info _DisplayLimits;
    [DataMember(EmitDefaultValue = false, Name = "UserDataCollectionDefChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "UserDataCollectionDefChanges_Info_ParametricDataDef")]
    protected new Info _ParametricDataDef;
    [DataMember(EmitDefaultValue = false, Name = "UserDataCollectionDefChanges_Info_IsRevOfRcd")]
    protected new Info _IsRevOfRcd;

    public DataPointChanges_Info DataPoints
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPoints), (object) value);
      }
      get
      {
        return (DataPointChanges_Info) this.PropertyGet(nameof (DataPoints));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Info Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Base));
      }
    }

    public Info DataPointLayout
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPointLayout), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataPointLayout));
      }
    }

    public new Info ParametricDataDefType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParametricDataDefType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParametricDataDefType));
      }
    }

    public Info DisplayLimits
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayLimits), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DisplayLimits));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }

    public new Info ParametricDataDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParametricDataDef), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParametricDataDef));
      }
    }

    public new Info IsRevOfRcd
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRevOfRcd), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsRevOfRcd));
      }
    }
  }
}
