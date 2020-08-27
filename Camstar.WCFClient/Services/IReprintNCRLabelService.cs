// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IReprintNCRLabelService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IReprintNCRLabelService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      ReprintNCRLabel reprintNCRLabel,
      ReprintNCRLabel_Parameters parameters,
      ReprintNCRLabel_Request request,
      out ReprintNCRLabel_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      ReprintNCRLabel reprintNCRLabel,
      ReprintNCRLabel_Parameters parameters,
      ReprintNCRLabel_Request request,
      out ReprintNCRLabel_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      ReprintNCRLabel reprintNCRLabel,
      ReprintNCRLabel_Parameters parameters,
      ReprintNCRLabel_Request request,
      out ReprintNCRLabel_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ReprintNCRLabel reprintNCRLabel,
      ReprintNCRLabel_Parameters parameters,
      ReprintNCRLabel_Request request,
      out ReprintNCRLabel_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ReprintNCRLabel reprintNCRLabel,
      ReprintNCRLabel_Parameters parameters,
      ReprintNCRLabel_Request request,
      out ReprintNCRLabel_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ReprintNCRLabel reprintNCRLabel,
      ReprintNCRLabel_LoadESigDetails_Parameters parameters,
      ReprintNCRLabel_Request request,
      out ReprintNCRLabel_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      ReprintNCRLabel reprintNCRLabel,
      ReprintNCRLabel_Parameters parameters,
      ReprintNCRLabel_Request request,
      out ReprintNCRLabel_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      ReprintNCRLabel reprintNCRLabel,
      ReprintNCRLabel_Parameters parameters,
      ReprintNCRLabel_Request request,
      out ReprintNCRLabel_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ReprintNCRLabelMethod[] methods,
      ReprintNCRLabel_Request request,
      out ReprintNCRLabel_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ReprintNCRLabel reprintNCRLabel,
      ReprintNCRLabel_Request request,
      out ReprintNCRLabel_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ReprintNCRLabel reprintNCRLabel,
      ReprintNCRLabel_Request request,
      out ReprintNCRLabel_Result result);
  }
}
