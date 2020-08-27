// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IRecipeDispenseService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IRecipeDispenseService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      RecipeDispense recipeDispense,
      RecipeDispense_Parameters parameters,
      RecipeDispense_Request request,
      out RecipeDispense_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      RecipeDispense recipeDispense,
      RecipeDispense_Parameters parameters,
      RecipeDispense_Request request,
      out RecipeDispense_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      RecipeDispense recipeDispense,
      RecipeDispense_Parameters parameters,
      RecipeDispense_Request request,
      out RecipeDispense_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      RecipeDispense recipeDispense,
      RecipeDispense_Parameters parameters,
      RecipeDispense_Request request,
      out RecipeDispense_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      RecipeDispense recipeDispense,
      RecipeDispense_Parameters parameters,
      RecipeDispense_Request request,
      out RecipeDispense_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      RecipeDispense recipeDispense,
      RecipeDispense_LoadESigDetails_Parameters parameters,
      RecipeDispense_Request request,
      out RecipeDispense_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      RecipeDispense recipeDispense,
      RecipeDispense_Parameters parameters,
      RecipeDispense_Request request,
      out RecipeDispense_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      RecipeDispense recipeDispense,
      RecipeDispense_Parameters parameters,
      RecipeDispense_Request request,
      out RecipeDispense_Result result);

    [OperationContract]
    ResultStatus ValidateBatchStatus(
      UserProfile userProfile,
      RecipeDispense recipeDispense,
      RecipeDispense_Parameters parameters,
      RecipeDispense_Request request,
      out RecipeDispense_Result result);

    [OperationContract]
    ResultStatus ValidateExpirationDates(
      UserProfile userProfile,
      RecipeDispense recipeDispense,
      RecipeDispense_Parameters parameters,
      RecipeDispense_Request request,
      out RecipeDispense_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      RecipeDispenseMethod[] methods,
      RecipeDispense_Request request,
      out RecipeDispense_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      RecipeDispense recipeDispense,
      RecipeDispense_Request request,
      out RecipeDispense_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      RecipeDispense recipeDispense,
      RecipeDispense_Request request,
      out RecipeDispense_Result result);
  }
}
