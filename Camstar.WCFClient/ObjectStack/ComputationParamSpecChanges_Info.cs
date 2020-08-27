// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComputationParamSpecChanges_Info
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
  public class ComputationParamSpecChanges_Info : NamedSubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamSpecChanges_Info_DataType")]
    protected Info _DataType;
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamSpecChanges_Info_DefaultValue")]
    protected Info _DefaultValue;
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamSpecChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamSpecChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamSpecChanges_Info_Name")]
    protected new Info _Name;

    public Info DataType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataType));
      }
    }

    public Info DefaultValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DefaultValue));
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

    public new Info ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ListItemToChange));
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
  }
}
