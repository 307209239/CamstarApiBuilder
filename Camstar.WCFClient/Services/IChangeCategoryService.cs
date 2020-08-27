// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IChangeCategoryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IChangeCategoryService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      ChangeCategory changeCategory,
      ChangeCategory_Parameters parameters,
      ChangeCategory_Request request,
      out ChangeCategory_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      ChangeCategory changeCategory,
      ChangeCategory_Parameters parameters,
      ChangeCategory_Request request,
      out ChangeCategory_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      ChangeCategory changeCategory,
      ChangeCategory_Parameters parameters,
      ChangeCategory_Request request,
      out ChangeCategory_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ChangeCategory changeCategory,
      ChangeCategory_Parameters parameters,
      ChangeCategory_Request request,
      out ChangeCategory_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ChangeCategory changeCategory,
      ChangeCategory_Parameters parameters,
      ChangeCategory_Request request,
      out ChangeCategory_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ChangeCategory changeCategory,
      ChangeCategory_Parameters parameters,
      ChangeCategory_Request request,
      out ChangeCategory_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      ChangeCategory changeCategory,
      ChangeCategory_Parameters parameters,
      ChangeCategory_Request request,
      out ChangeCategory_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      ChangeCategory changeCategory,
      ChangeCategory_Parameters parameters,
      ChangeCategory_Request request,
      out ChangeCategory_Result result);

    [OperationContract]
    ResultStatus SetEscalationDate(
      UserProfile userProfile,
      ChangeCategory changeCategory,
      ChangeCategory_Parameters parameters,
      ChangeCategory_Request request,
      out ChangeCategory_Result result);

    [OperationContract]
    ResultStatus SetTriageComplete(
      UserProfile userProfile,
      ChangeCategory changeCategory,
      ChangeCategory_Parameters parameters,
      ChangeCategory_Request request,
      out ChangeCategory_Result result);

    [OperationContract]
    ResultStatus ValidateCategoryTransition(
      UserProfile userProfile,
      ChangeCategory changeCategory,
      ChangeCategory_ValidateCategoryTransition_Parameters parameters,
      ChangeCategory_Request request,
      out ChangeCategory_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ChangeCategoryMethod[] methods,
      ChangeCategory_Request request,
      out ChangeCategory_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ChangeCategory changeCategory,
      ChangeCategory_Request request,
      out ChangeCategory_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ChangeCategory changeCategory,
      ChangeCategory_Request request,
      out ChangeCategory_Result result);
  }
}
