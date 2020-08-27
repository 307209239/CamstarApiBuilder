// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPersonalizationChanges_Environment
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
  public class UIPersonalizationChanges_Environment : SubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalizationChanges_Environment_Content")]
    [Metadata("LongString", "", false, false, false, "String", 1051505, false, false, false, null)]
    protected Environment _Content;
    [Metadata("Changes CDO for ChangeHistory.", "ChangeHistoryChanges", false, false, false, "ChangeHistoryChanges", 1048765, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalizationChanges_Environment_ChangeHistory")]
    protected ChangeHistoryChanges_Environment _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalizationChanges_Environment_ObjectToChange")]
    [Metadata("UI Personalization data", "UIPersonalization", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalizationChanges_Environment_ListItemToChange")]
    [Metadata("UI Personalization data", "UIPersonalizationChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1053272, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalizationChanges_Environment_WorkspaceId")]
    protected Environment _WorkspaceId;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1048824, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalizationChanges_Environment_Owner")]
    protected Environment _Owner;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, false, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalizationChanges_Environment_IsFrozen")]
    protected Environment _IsFrozen;

    public Environment Content
    {
      [param: In] set
      {
        this.PropertySet(nameof (Content), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Content));
      }
    }

    public ChangeHistoryChanges_Environment ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistoryChanges_Environment) this.PropertyGet(nameof (ChangeHistory));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Environment WorkspaceId
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkspaceId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkspaceId));
      }
    }

    public Environment Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Owner));
      }
    }

    public Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
