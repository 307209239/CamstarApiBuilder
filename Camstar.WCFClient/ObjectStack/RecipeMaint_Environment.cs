// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecipeMaint_Environment
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
  public class RecipeMaint_Environment : DocumentMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "RecipeMaint_Environment_ObjectListInquiry")]
    [Metadata("A sub class of DocumentBase defines recipe.", "RecipeBase", false, false, true, "RevisionedObjectRef", 1048874, false, true, false, null)]
    protected new Environment _ObjectListInquiry;
    [Metadata("A sub class of DocumentBase defines recipe.", "RecipeBase", false, false, false, "RevisionedObjectRef", 1049292, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecipeMaint_Environment_BaseToChange")]
    protected new Environment _BaseToChange;
    [DataMember(EmitDefaultValue = false, Name = "RecipeMaint_Environment_ObjectChanges")]
    [Metadata("Changes CDO for Recipe.", "RecipeChanges", false, false, false, "RecipeChanges", 1048873, true, false, false, null)]
    protected RecipeChanges_Environment _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "RecipeMaint_Environment_ObjectToChange")]
    [Metadata("A subclass of Document describes recipe.", "Recipe", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;

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

    public new Environment BaseToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (BaseToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BaseToChange));
      }
    }

    public RecipeChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (RecipeChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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
