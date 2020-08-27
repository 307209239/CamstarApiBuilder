// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TriageSpecChanges_Info
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
  public class TriageSpecChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "TriageSpecChanges_Info_TriageSpecDetails")]
    protected TriageSpecDetailChanges_Info _TriageSpecDetails;
    [DataMember(EmitDefaultValue = false, Name = "TriageSpecChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "TriageSpecChanges_Info_BusinessRules")]
    protected Info _BusinessRules;
    [DataMember(EmitDefaultValue = false, Name = "TriageSpecChanges_Info_Name")]
    protected new Info _Name;

    public TriageSpecDetailChanges_Info TriageSpecDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriageSpecDetails), (object) value);
      }
      get
      {
        return (TriageSpecDetailChanges_Info) this.PropertyGet(nameof (TriageSpecDetails));
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

    public Info BusinessRules
    {
      [param: In] set
      {
        this.PropertySet(nameof (BusinessRules), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BusinessRules));
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
