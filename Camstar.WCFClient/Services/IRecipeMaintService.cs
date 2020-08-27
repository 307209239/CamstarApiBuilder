// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IRecipeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IRecipeMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      RecipeMaint recipeMaint,
      RecipeMaint_Parameters parameters,
      RecipeMaint_Request request,
      out RecipeMaint_Result result);

    [OperationContract]
    ResultStatus DeleteAllRevisions(
      UserProfile userProfile,
      RecipeMaint recipeMaint,
      RecipeMaint_Parameters parameters,
      RecipeMaint_Request request,
      out RecipeMaint_Result result);

    [OperationContract]
    ResultStatus DownloadFile(
      UserProfile userProfile,
      RecipeMaint recipeMaint,
      RecipeMaint_Parameters parameters,
      RecipeMaint_Request request,
      out RecipeMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      RecipeMaint recipeMaint,
      RecipeMaint_Parameters parameters,
      RecipeMaint_Request request,
      out RecipeMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      RecipeMaint recipeMaint,
      RecipeMaint_Parameters parameters,
      RecipeMaint_Request request,
      out RecipeMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      RecipeMaint recipeMaint,
      RecipeMaint_Parameters parameters,
      RecipeMaint_Request request,
      out RecipeMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      RecipeMaint recipeMaint,
      RecipeMaint_LoadESigDetails_Parameters parameters,
      RecipeMaint_Request request,
      out RecipeMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      RecipeMaint recipeMaint,
      RecipeMaint_Parameters parameters,
      RecipeMaint_Request request,
      out RecipeMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      RecipeMaint recipeMaint,
      RecipeMaint_Parameters parameters,
      RecipeMaint_Request request,
      out RecipeMaint_Result result);

    [OperationContract]
    ResultStatus NewRev(
      UserProfile userProfile,
      RecipeMaint recipeMaint,
      RecipeMaint_Parameters parameters,
      RecipeMaint_Request request,
      out RecipeMaint_Result result);

    [OperationContract]
    ResultStatus NewRevCopy(
      UserProfile userProfile,
      RecipeMaint recipeMaint,
      RecipeMaint_Parameters parameters,
      RecipeMaint_Request request,
      out RecipeMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      RecipeMaint recipeMaint,
      RecipeMaint_Parameters parameters,
      RecipeMaint_Request request,
      out RecipeMaint_Result result);

    [OperationContract]
    ResultStatus SaveAsRev(
      UserProfile userProfile,
      RecipeMaint recipeMaint,
      RecipeMaint_Parameters parameters,
      RecipeMaint_Request request,
      out RecipeMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      RecipeMaint recipeMaint,
      RecipeMaint_Parameters parameters,
      RecipeMaint_Request request,
      out RecipeMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      RecipeMaintMethod[] methods,
      RecipeMaint_Request request,
      out RecipeMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      RecipeMaint recipeMaint,
      RecipeMaint_Request request,
      out RecipeMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      RecipeMaint recipeMaint,
      RecipeMaint_Request request,
      out RecipeMaint_Result result);
  }
}
