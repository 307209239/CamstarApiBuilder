// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ApprovalSheetMapChanges_Info
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
  public class ApprovalSheetMapChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetMapChanges_Info_ResolutionAction")]
    protected Info _ResolutionAction;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetMapChanges_Info_ApprovalSheetTemplate")]
    protected Info _ApprovalSheetTemplate;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetMapChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetMapChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetMapChanges_Info_ApprovalRequired")]
    protected Info _ApprovalRequired;
    [DataMember(EmitDefaultValue = false, Name = "ApprovalSheetMapChanges_Info_IsFrozen")]
    protected Info _IsFrozen;

    public Info ResolutionAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResolutionAction), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResolutionAction));
      }
    }

    public Info ApprovalSheetTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetTemplate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalSheetTemplate));
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

    public Info ApprovalRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalRequired), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalRequired));
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
