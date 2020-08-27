// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IRecipeListMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IRecipeListMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      RecipeListMaint recipeListMaint,
      RecipeListMaint_Parameters parameters,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result);

    [OperationContract]
    ResultStatus DeleteAllRevisions(
      UserProfile userProfile,
      RecipeListMaint recipeListMaint,
      RecipeListMaint_Parameters parameters,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      RecipeListMaint recipeListMaint,
      RecipeListMaint_Parameters parameters,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      RecipeListMaint recipeListMaint,
      RecipeListMaint_Parameters parameters,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      RecipeListMaint recipeListMaint,
      RecipeListMaint_Parameters parameters,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      RecipeListMaint recipeListMaint,
      RecipeListMaint_LoadESigDetails_Parameters parameters,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      RecipeListMaint recipeListMaint,
      RecipeListMaint_Parameters parameters,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      RecipeListMaint recipeListMaint,
      RecipeListMaint_Parameters parameters,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result);

    [OperationContract]
    ResultStatus NewRev(
      UserProfile userProfile,
      RecipeListMaint recipeListMaint,
      RecipeListMaint_Parameters parameters,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result);

    [OperationContract]
    ResultStatus NewRevCopy(
      UserProfile userProfile,
      RecipeListMaint recipeListMaint,
      RecipeListMaint_Parameters parameters,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      RecipeListMaint recipeListMaint,
      RecipeListMaint_Parameters parameters,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result);

    [OperationContract]
    ResultStatus SaveAsRev(
      UserProfile userProfile,
      RecipeListMaint recipeListMaint,
      RecipeListMaint_Parameters parameters,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      RecipeListMaint recipeListMaint,
      RecipeListMaint_Parameters parameters,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      RecipeListMaintMethod[] methods,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      RecipeListMaint recipeListMaint,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      RecipeListMaint recipeListMaint,
      RecipeListMaint_Request request,
      out RecipeListMaint_Result result);
  }
}
