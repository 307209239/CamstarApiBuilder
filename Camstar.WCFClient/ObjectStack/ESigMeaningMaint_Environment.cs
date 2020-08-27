// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ESigMeaningMaint_Environment
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
  public class ESigMeaningMaint_Environment : UserCodeMaint_Environment
  {
    [Metadata("Descriptive meaning for an Electronic Signature requirement.", "ESigMeaningChanges", false, false, false, "ESigMeaningChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigMeaningMaint_Environment_ObjectChanges")]
    protected ESigMeaningChanges_Environment _ObjectChanges;
    [Metadata("Descriptive meaning for an Electronic Signature requirement.", "ESigMeaning", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigMeaningMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "ESigMeaningMaint_Environment_ObjectToChange")]
    [Metadata("Descriptive meaning for an Electronic Signature requirement.", "ESigMeaning", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;

    public ESigMeaningChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ESigMeaningChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

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
  }
}
