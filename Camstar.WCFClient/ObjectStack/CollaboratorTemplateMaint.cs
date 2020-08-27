// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollaboratorTemplateMaint
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
  public class CollaboratorTemplateMaint : NamedDataObjectMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorTemplateMaint_ObjectChanges")]
    protected CollaboratorTemplateChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorTemplateMaint_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorTemplateMaint_ObjectListInquiry")]
    protected new NamedObjectRef[] _ObjectListInquiry;

    public override bool Equals(object obj)
    {
      return obj is CollaboratorTemplateMaint && object.Equals((object) this._ObjectChanges, (object) ((CollaboratorTemplateMaint) obj)._ObjectChanges) && (object.Equals((object) this._ObjectToChange, (object) ((CollaboratorTemplateMaint) obj)._ObjectToChange) && this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((CollaboratorTemplateMaint) obj)._ObjectListInquiry)) && base.Equals(obj);
    }

    public CollaboratorTemplateChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (CollaboratorTemplateChanges) this.PropertyGet(nameof (ObjectChanges));
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
  }
}
