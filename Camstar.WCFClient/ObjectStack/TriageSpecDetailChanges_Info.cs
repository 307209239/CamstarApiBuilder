// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TriageSpecDetailChanges_Info
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
  public class TriageSpecDetailChanges_Info : NamedSubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "TriageSpecDetailChanges_Info_Role")]
    protected Info _Role;
    [DataMember(EmitDefaultValue = false, Name = "TriageSpecDetailChanges_Info_ToCategory")]
    protected Info _ToCategory;
    [DataMember(EmitDefaultValue = false, Name = "TriageSpecDetailChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "TriageSpecDetailChanges_Info_ChecklistTemplate")]
    protected Info _ChecklistTemplate;
    [DataMember(EmitDefaultValue = false, Name = "TriageSpecDetailChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "TriageSpecDetailChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "TriageSpecDetailChanges_Info_Owner")]
    protected Info _Owner;

    public Info Role
    {
      [param: In] set
      {
        this.PropertySet(nameof (Role), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Role));
      }
    }

    public Info ToCategory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToCategory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToCategory));
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

    public Info ChecklistTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistTemplate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChecklistTemplate));
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

    public Info Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Owner));
      }
    }
  }
}
