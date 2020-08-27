// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserProfileChanges_Environment
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
  public class UserProfileChanges_Environment : SubentityChanges_Environment
  {
    [Metadata("Changes CDO for ChangeHistory.", "ChangeHistoryChanges", false, false, false, "ChangeHistoryChanges", 1048765, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UserProfileChanges_Environment_ChangeHistory")]
    protected ChangeHistoryChanges_Environment _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "UserProfileChanges_Environment_ObjectToChange")]
    [Metadata("Session information for an employee", "UserProfile", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Session information for an employee", "UserProfileChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UserProfileChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UserProfileChanges_Environment_ShowLineAssignmentOnLogon")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052562, false, false, false, "1")]
    protected Environment _ShowLineAssignmentOnLogon;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, false, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "UserProfileChanges_Environment_IsFrozen")]
    protected Environment _IsFrozen;

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

    public Environment ShowLineAssignmentOnLogon
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowLineAssignmentOnLogon), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ShowLineAssignmentOnLogon));
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
