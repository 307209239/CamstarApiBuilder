// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComputationItemChanges_Info
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
  public class ComputationItemChanges_Info : TaskItemChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ComputationItemChanges_Info_DataCollectionDef")]
    protected Info _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "ComputationItemChanges_Info_ComputationParams")]
    protected ComputationParamMapChanges_Info _ComputationParams;
    [DataMember(EmitDefaultValue = false, Name = "ComputationItemChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ComputationItemChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ComputationItemChanges_Info_Computation")]
    protected Info _Computation;

    public Info DataCollectionDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDef), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataCollectionDef));
      }
    }

    public ComputationParamMapChanges_Info ComputationParams
    {
      [param: In] set
      {
        this.PropertySet(nameof (ComputationParams), (object) value);
      }
      get
      {
        return (ComputationParamMapChanges_Info) this.PropertyGet(nameof (ComputationParams));
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

    public Info Computation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Computation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Computation));
      }
    }
  }
}
