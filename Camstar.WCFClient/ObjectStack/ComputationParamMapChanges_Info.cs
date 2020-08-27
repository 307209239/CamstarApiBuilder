// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComputationParamMapChanges_Info
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
  public class ComputationParamMapChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamMapChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamMapChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamMapChanges_Info_DataPoint")]
    protected Info _DataPoint;
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamMapChanges_Info_ComputationVariable")]
    protected Info _ComputationVariable;
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamMapChanges_Info_IsFrozen")]
    protected Info _IsFrozen;

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

    public Info DataPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPoint), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataPoint));
      }
    }

    public Info ComputationVariable
    {
      [param: In] set
      {
        this.PropertySet(nameof (ComputationVariable), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ComputationVariable));
      }
    }

    public Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
