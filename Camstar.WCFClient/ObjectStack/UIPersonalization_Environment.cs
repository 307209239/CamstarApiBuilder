// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPersonalization_Environment
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
  public class UIPersonalization_Environment : Subentity_Environment
  {
    [Metadata("This subentity will maintain the data for the esignatures associated with the last update to its parent object.", "ModelingESigHistoryDetail", false, false, true, "SubentityRef", 1052361, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalization_Environment_ESigHistoryDetails")]
    protected Environment _ESigHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalization_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalization_Environment_Content")]
    [Metadata("LongString", "", false, false, true, "String", 1051505, false, false, false, null)]
    protected Environment _Content;
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalization_Environment_WorkspaceId")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1053272, false, false, false, null)]
    protected Environment _WorkspaceId;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1048824, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalization_Environment_Owner")]
    protected Environment _Owner;
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalization_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected Environment _IsFrozen;
    [Metadata("Every modeling entity includes a Change Status. It is used to record the current Change (Maintenance) Status (i.e., maintenance is currently in progress for a specific Product Definition) and to track who made the last change and when. This should be extendible to a complete history over time.", "ChangeHistory", false, false, true, "ChangeHistory", 1048765, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalization_Environment_ChangeHistory")]
    protected ChangeHistory_Environment _ChangeHistory;

    public Environment ESigHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigHistoryDetails), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ESigHistoryDetails));
      }
    }

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

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

    public ChangeHistory_Environment ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistory_Environment) this.PropertyGet(nameof (ChangeHistory));
      }
    }
  }
}
