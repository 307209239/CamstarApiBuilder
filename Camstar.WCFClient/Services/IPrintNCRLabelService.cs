// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IPrintNCRLabelService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IPrintNCRLabelService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      PrintNCRLabel printNCRLabel,
      PrintNCRLabel_Parameters parameters,
      PrintNCRLabel_Request request,
      out PrintNCRLabel_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      PrintNCRLabel printNCRLabel,
      PrintNCRLabel_Parameters parameters,
      PrintNCRLabel_Request request,
      out PrintNCRLabel_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      PrintNCRLabel printNCRLabel,
      PrintNCRLabel_Parameters parameters,
      PrintNCRLabel_Request request,
      out PrintNCRLabel_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      PrintNCRLabel printNCRLabel,
      PrintNCRLabel_Parameters parameters,
      PrintNCRLabel_Request request,
      out PrintNCRLabel_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      PrintNCRLabel printNCRLabel,
      PrintNCRLabel_Parameters parameters,
      PrintNCRLabel_Request request,
      out PrintNCRLabel_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      PrintNCRLabel printNCRLabel,
      PrintNCRLabel_LoadESigDetails_Parameters parameters,
      PrintNCRLabel_Request request,
      out PrintNCRLabel_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      PrintNCRLabel printNCRLabel,
      PrintNCRLabel_Parameters parameters,
      PrintNCRLabel_Request request,
      out PrintNCRLabel_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      PrintNCRLabel printNCRLabel,
      PrintNCRLabel_Parameters parameters,
      PrintNCRLabel_Request request,
      out PrintNCRLabel_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      PrintNCRLabelMethod[] methods,
      PrintNCRLabel_Request request,
      out PrintNCRLabel_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      PrintNCRLabel printNCRLabel,
      PrintNCRLabel_Request request,
      out PrintNCRLabel_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      PrintNCRLabel printNCRLabel,
      PrintNCRLabel_Request request,
      out PrintNCRLabel_Result result);
  }
}
