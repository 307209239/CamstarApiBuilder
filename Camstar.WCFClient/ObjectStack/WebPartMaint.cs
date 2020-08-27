// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WebPartMaint
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
  public class WebPartMaint : UIProviderComponentMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "WebPartMaint_ObjectListInquiry")]
    protected new NamedObjectRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "WebPartMaint_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "WebPartMaint_ContentAction")]
    protected Enumeration<ContentActionEnum, int> _ContentAction;
    [DataMember(EmitDefaultValue = false, Name = "WebPartMaint_ObjectChanges")]
    protected WebPartChanges _ObjectChanges;

    public override bool Equals(object obj)
    {
      return obj is WebPartMaint && this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((WebPartMaint) obj)._ObjectListInquiry) && (object.Equals((object) this._ObjectToChange, (object) ((WebPartMaint) obj)._ObjectToChange) && object.Equals((object) this._ContentAction, (object) ((WebPartMaint) obj)._ContentAction)) && object.Equals((object) this._ObjectChanges, (object) ((WebPartMaint) obj)._ObjectChanges) && base.Equals(obj);
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

    public Enumeration<ContentActionEnum, int> ContentAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContentAction), (object) value);
      }
      get
      {
        return (Enumeration<ContentActionEnum, int>) this.PropertyGet(nameof (ContentAction));
      }
    }

    public WebPartChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (WebPartChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
