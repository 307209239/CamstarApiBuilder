// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivityDispositionMaint_Environment
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
  public class ActivityDispositionMaint_Environment : ActivityMaint_Environment
  {
    [Metadata("This activity is used to disposition material reported in the quality system.", "ActivityDisposition", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivityDispositionMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("This activity is used to disposition material reported in the quality system.", "ActivityDisposition", false, false, true, "NamedSubentityRef", 1048874, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivityDispositionMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "ActivityDispositionMaint_Environment_ObjectChanges")]
    [Metadata("ActivityDispositionChanges", "ActivityDispositionChanges", false, false, false, "ActivityDispositionChanges", 1048873, true, false, false, null)]
    protected ActivityDispositionChanges_Environment _ObjectChanges;
    [Metadata("The template for disposition activities which record the disposition of material associated with QualityObject records.", "ActivityTemplateDisposition", false, false, false, "NamedObjectRef", 1051395, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivityDispositionMaint_Environment_Template")]
    protected new Environment _Template;

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

    public ActivityDispositionChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ActivityDispositionChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new Environment Template
    {
      [param: In] set
      {
        this.PropertySet(nameof (Template), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Template));
      }
    }
  }
}
