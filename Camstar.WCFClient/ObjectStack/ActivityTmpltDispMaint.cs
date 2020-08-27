// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivityTmpltDispMaint
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
  public class ActivityTmpltDispMaint : ActivityTemplateMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "ActivityTmpltDispMaint_ObjectChanges")]
    protected ActivityTmpltDispChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTmpltDispMaint_ObjectListInquiry")]
    protected new NamedObjectRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTmpltDispMaint_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTmpltDispMaint_ProcessObjectTemplateDetails")]
    protected ActivityTemplateDisposition _ProcessObjectTemplateDetails;

    public override bool Equals(object obj)
    {
      return obj is ActivityTmpltDispMaint && object.Equals((object) this._ObjectChanges, (object) ((ActivityTmpltDispMaint) obj)._ObjectChanges) && (this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((ActivityTmpltDispMaint) obj)._ObjectListInquiry) && object.Equals((object) this._ObjectToChange, (object) ((ActivityTmpltDispMaint) obj)._ObjectToChange)) && object.Equals((object) this._ProcessObjectTemplateDetails, (object) ((ActivityTmpltDispMaint) obj)._ProcessObjectTemplateDetails) && base.Equals(obj);
    }

    public ActivityTmpltDispChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ActivityTmpltDispChanges) this.PropertyGet(nameof (ObjectChanges));
      }
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

    public ActivityTemplateDisposition ProcessObjectTemplateDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectTemplateDetails), (object) value);
      }
      get
      {
        return (ActivityTemplateDisposition) this.PropertyGet(nameof (ProcessObjectTemplateDetails));
      }
    }
  }
}
