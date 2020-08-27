// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollaboratorTemplateMaint_Environment
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
  public class CollaboratorTemplateMaint_Environment : NamedDataObjectMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorTemplateMaint_Environment_ObjectChanges")]
    [Metadata("The template is used to pre-define the collaborators that will be attached to the object.", "CollaboratorTemplateChanges", false, false, false, "CollaboratorTemplateChanges", 1048873, true, false, false, null)]
    protected CollaboratorTemplateChanges_Environment _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorTemplateMaint_Environment_ObjectToChange")]
    [Metadata("The template is used to pre-define the collaborators that will be attached to the object.", "CollaboratorTemplate", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("The template is used to pre-define the collaborators that will be attached to the object.", "CollaboratorTemplate", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollaboratorTemplateMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;

    public CollaboratorTemplateChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (CollaboratorTemplateChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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
  }
}
