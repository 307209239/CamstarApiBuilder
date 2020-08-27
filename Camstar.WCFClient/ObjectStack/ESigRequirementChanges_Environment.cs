// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ESigRequirementChanges_Environment
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
  public class ESigRequirementChanges_Environment : NamedDataObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ESigRequirementChanges_Environment_ObjectToChange")]
    [Metadata("Contains the list of signatures that should be collected in a single transaction.", "ESigRequirement", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("The detailed requirements for an Electronic Signature requirement.  Each detail will require a unique signature when the requirement is implemented in a service.", "ESigReqDetailChanges", false, false, false, "ESigReqDetailChanges", 1050597, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigRequirementChanges_Environment_ESigReqDetails")]
    protected ESigReqDetailChanges_Environment _ESigReqDetails;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050346, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigRequirementChanges_Environment_Name")]
    protected new Environment _Name;

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

    public ESigReqDetailChanges_Environment ESigReqDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigReqDetails), (object) value);
      }
      get
      {
        return (ESigReqDetailChanges_Environment) this.PropertyGet(nameof (ESigReqDetails));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
