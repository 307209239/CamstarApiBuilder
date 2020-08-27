// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivityTemplateMaint
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
  public class ActivityTemplateMaint : ProcessObjectTemplateMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateMaint_ObjectListInquiry")]
    protected new NamedObjectRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateMaint_ProcessObjectTemplateDetails")]
    protected ActivityTemplate _ProcessObjectTemplateDetails;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateMaint_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateMaint_ObjectChanges")]
    protected ActivityTemplateChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateMaint_ActivityType")]
    protected Primitive<string> _ActivityType;

    public override bool Equals(object obj)
    {
      return obj is ActivityTemplateMaint && this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((ActivityTemplateMaint) obj)._ObjectListInquiry) && (object.Equals((object) this._ProcessObjectTemplateDetails, (object) ((ActivityTemplateMaint) obj)._ProcessObjectTemplateDetails) && object.Equals((object) this._ObjectToChange, (object) ((ActivityTemplateMaint) obj)._ObjectToChange)) && (object.Equals((object) this._ObjectChanges, (object) ((ActivityTemplateMaint) obj)._ObjectChanges) && object.Equals((object) this._ActivityType, (object) ((ActivityTemplateMaint) obj)._ActivityType)) && base.Equals(obj);
    }

    public new NamedObjectRef[] ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public ActivityTemplate ProcessObjectTemplateDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectTemplateDetails), (object) value);
      }
      get
      {
        return (ActivityTemplate) this.PropertyGet(nameof (ProcessObjectTemplateDetails));
      }
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public ActivityTemplateChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ActivityTemplateChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public Primitive<string> ActivityType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActivityType), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ActivityType));
      }
    }
  }
}
