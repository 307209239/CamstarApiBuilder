// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRCauseCodeChanges_Environment
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
  public class NCRCauseCodeChanges_Environment : UserCodeChanges_Environment
  {
    [Metadata("A User Code Object Group that represents a group of NCRResolutionCodes.", "NCRResolutionCodeGroup", false, false, false, "NamedObjectRef", 1050407, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRCauseCodeChanges_Environment_NCRResolutionCodeGroup")]
    protected Environment _NCRResolutionCodeGroup;
    [Metadata("Identifies the Root Cause of why the material failed.", "NCRCauseCode", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRCauseCodeChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "NCRCauseCodeChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1051782, false, false, false, null)]
    protected new Environment _Name;

    public Environment NCRResolutionCodeGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRResolutionCodeGroup), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NCRResolutionCodeGroup));
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
