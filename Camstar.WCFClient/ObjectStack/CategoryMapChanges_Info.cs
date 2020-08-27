// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CategoryMapChanges_Info
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
  public class CategoryMapChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CategoryMapChanges_Info_Role")]
    protected Info _Role;
    [DataMember(EmitDefaultValue = false, Name = "CategoryMapChanges_Info_Category")]
    protected Info _Category;
    [DataMember(EmitDefaultValue = false, Name = "CategoryMapChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "CategoryMapChanges_Info_TriageSpec")]
    protected Info _TriageSpec;
    [DataMember(EmitDefaultValue = false, Name = "CategoryMapChanges_Info_ApprovalSheetMap")]
    protected ApprovalSheetMapChanges_Info _ApprovalSheetMap;
    [DataMember(EmitDefaultValue = false, Name = "CategoryMapChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "CategoryMapChanges_Info_IsFrozen")]
    protected Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "CategoryMapChanges_Info_Owner")]
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

    public Info Category
    {
      [param: In] set
      {
        this.PropertySet(nameof (Category), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Category));
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

    public Info TriageSpec
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriageSpec), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TriageSpec));
      }
    }

    public ApprovalSheetMapChanges_Info ApprovalSheetMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetMap), (object) value);
      }
      get
      {
        return (ApprovalSheetMapChanges_Info) this.PropertyGet(nameof (ApprovalSheetMap));
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
