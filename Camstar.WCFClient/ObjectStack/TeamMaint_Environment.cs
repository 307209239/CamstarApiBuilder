// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TeamMaint_Environment
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
  public class TeamMaint_Environment : NamedDataObjectMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "TeamMaint_Environment_ObjectListInquiry")]
    [Metadata("An alternate means of grouping production information to \"shift\".  For example, \"day\" and \"night\" shifts that are schedule to work on Monday-Thursday might be assigned to team \"Red\", while day and night shifts that work Friday-Sunday would be assigned to team \"Blues\".", "Team", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    protected new Environment _ObjectListInquiry;
    [Metadata("An alternate means of grouping production information to \"shift\".  For example, \"day\" and \"night\" shifts that are schedule to work on Monday-Thursday might be assigned to team \"Red\", while day and night shifts that work Friday-Sunday would be assigned to team \"Blues\".", "Team", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "TeamMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("An alternate means of grouping production information to \"shift\".  For example, \"day\" and \"night\" shifts that are schedule to work on Monday-Thursday might be assigned to team \"Red\", while day and night shifts that work Friday-Sunday would be assigned to team \"Blues\".", "TeamChanges", false, false, false, "TeamChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TeamMaint_Environment_ObjectChanges")]
    protected TeamChanges_Environment _ObjectChanges;

    public new Environment ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectListInquiry));
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

    public TeamChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (TeamChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
