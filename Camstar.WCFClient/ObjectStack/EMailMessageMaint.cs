// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EMailMessageMaint
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
  public class EMailMessageMaint : NamedDataObjectMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "EMailMessageMaint_ObjectListInquiry")]
    protected new NamedObjectRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "EMailMessageMaint_ObjectChanges")]
    protected EMailMessageChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "EMailMessageMaint_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;

    public override bool Equals(object obj)
    {
      return obj is EMailMessageMaint && this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((EMailMessageMaint) obj)._ObjectListInquiry) && (object.Equals((object) this._ObjectChanges, (object) ((EMailMessageMaint) obj)._ObjectChanges) && object.Equals((object) this._ObjectToChange, (object) ((EMailMessageMaint) obj)._ObjectToChange)) && base.Equals(obj);
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

    public EMailMessageChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (EMailMessageChanges) this.PropertyGet(nameof (ObjectChanges));
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
  }
}
