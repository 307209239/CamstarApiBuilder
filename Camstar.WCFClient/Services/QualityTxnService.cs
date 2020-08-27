// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.QualityTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class QualityTxnService : ShopFloorBase
  {
    public QualityTxnService(UserProfile userProfile)
    {
      this.Initialize(typeof (IQualityTxnService), userProfile);
    }

    public ResultStatus AddAction(
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      result = (QualityTxn_Result) null;
      this.OnBeforeCall(nameof (AddAction), (DCObject) qualityTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQualityTxnService) this._Channel).AddAction(this._UserProfile, qualityTxn, parameters, request, out result) : this.AddMethod((Method) new QualityTxnMethod(qualityTxn, QualityTxnMethods.AddAction, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AddAction), res, (DCObject) qualityTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AddAction()
    {
      return this.AddAction((QualityTxn) null, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus AddAction(QualityTxn qualityTxn)
    {
      return this.AddAction(qualityTxn, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus AddAction(
      QualityTxn qualityTxn,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      return this.AddAction(qualityTxn, (QualityTxn_Parameters) null, request, out result);
    }

    public ResultStatus CreateParametricData(
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      result = (QualityTxn_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) qualityTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQualityTxnService) this._Channel).CreateParametricData(this._UserProfile, qualityTxn, parameters, request, out result) : this.AddMethod((Method) new QualityTxnMethod(qualityTxn, QualityTxnMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) qualityTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((QualityTxn) null, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus CreateParametricData(QualityTxn qualityTxn)
    {
      return this.CreateParametricData(qualityTxn, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus CreateParametricData(
      QualityTxn qualityTxn,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      return this.CreateParametricData(qualityTxn, (QualityTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      result = (QualityTxn_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) qualityTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQualityTxnService) this._Channel).GetActions(this._UserProfile, qualityTxn, parameters, request, out result) : this.AddMethod((Method) new QualityTxnMethod(qualityTxn, QualityTxnMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) qualityTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((QualityTxn) null, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus GetActions(QualityTxn qualityTxn)
    {
      return this.GetActions(qualityTxn, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus GetActions(
      QualityTxn qualityTxn,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      return this.GetActions(qualityTxn, (QualityTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      result = (QualityTxn_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) qualityTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQualityTxnService) this._Channel).GetDataPoints(this._UserProfile, qualityTxn, parameters, request, out result) : this.AddMethod((Method) new QualityTxnMethod(qualityTxn, QualityTxnMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) qualityTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((QualityTxn) null, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus GetDataPoints(QualityTxn qualityTxn)
    {
      return this.GetDataPoints(qualityTxn, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus GetDataPoints(
      QualityTxn qualityTxn,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      return this.GetDataPoints(qualityTxn, (QualityTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetOrganization(
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      result = (QualityTxn_Result) null;
      this.OnBeforeCall(nameof (GetOrganization), (DCObject) qualityTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQualityTxnService) this._Channel).GetOrganization(this._UserProfile, qualityTxn, parameters, request, out result) : this.AddMethod((Method) new QualityTxnMethod(qualityTxn, QualityTxnMethods.GetOrganization, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetOrganization), res, (DCObject) qualityTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetOrganization()
    {
      return this.GetOrganization((QualityTxn) null, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus GetOrganization(QualityTxn qualityTxn)
    {
      return this.GetOrganization(qualityTxn, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus GetOrganization(
      QualityTxn qualityTxn,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      return this.GetOrganization(qualityTxn, (QualityTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      result = (QualityTxn_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) qualityTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQualityTxnService) this._Channel).GetWIPMsgs(this._UserProfile, qualityTxn, parameters, request, out result) : this.AddMethod((Method) new QualityTxnMethod(qualityTxn, QualityTxnMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) qualityTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((QualityTxn) null, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(QualityTxn qualityTxn)
    {
      return this.GetWIPMsgs(qualityTxn, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(
      QualityTxn qualityTxn,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      return this.GetWIPMsgs(qualityTxn, (QualityTxn_Parameters) null, request, out result);
    }

    public ResultStatus InitializeProcessObjectActions(
      QualityTxn qualityTxn,
      QualityTxn_InitializeProcessObjectActions_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      result = (QualityTxn_Result) null;
      this.OnBeforeCall(nameof (InitializeProcessObjectActions), (DCObject) qualityTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQualityTxnService) this._Channel).InitializeProcessObjectActions(this._UserProfile, qualityTxn, parameters, request, out result) : this.AddMethod((Method) new QualityTxnMethod(qualityTxn, QualityTxnMethods.InitializeProcessObjectActions, (QualityTxn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (InitializeProcessObjectActions), res, (DCObject) qualityTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus InitializeProcessObjectActions()
    {
      return this.InitializeProcessObjectActions((QualityTxn) null, (QualityTxn_InitializeProcessObjectActions_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus InitializeProcessObjectActions(QualityTxn qualityTxn)
    {
      return this.InitializeProcessObjectActions(qualityTxn, (QualityTxn_InitializeProcessObjectActions_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus InitializeProcessObjectActions(
      QualityTxn qualityTxn,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      return this.InitializeProcessObjectActions(qualityTxn, (QualityTxn_InitializeProcessObjectActions_Parameters) null, request, out result);
    }

    public ResultStatus InitializeProcessObjectActions_User(
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      result = (QualityTxn_Result) null;
      this.OnBeforeCall(nameof (InitializeProcessObjectActions_User), (DCObject) qualityTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQualityTxnService) this._Channel).InitializeProcessObjectActions_User(this._UserProfile, qualityTxn, parameters, request, out result) : this.AddMethod((Method) new QualityTxnMethod(qualityTxn, QualityTxnMethods.InitializeProcessObjectActions_User, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (InitializeProcessObjectActions_User), res, (DCObject) qualityTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus InitializeProcessObjectActions_User()
    {
      return this.InitializeProcessObjectActions_User((QualityTxn) null, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus InitializeProcessObjectActions_User(QualityTxn qualityTxn)
    {
      return this.InitializeProcessObjectActions_User(qualityTxn, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus InitializeProcessObjectActions_User(
      QualityTxn qualityTxn,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      return this.InitializeProcessObjectActions_User(qualityTxn, (QualityTxn_Parameters) null, request, out result);
    }

    public ResultStatus InitializeQualityObjectActions(
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      result = (QualityTxn_Result) null;
      this.OnBeforeCall(nameof (InitializeQualityObjectActions), (DCObject) qualityTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQualityTxnService) this._Channel).InitializeQualityObjectActions(this._UserProfile, qualityTxn, parameters, request, out result) : this.AddMethod((Method) new QualityTxnMethod(qualityTxn, QualityTxnMethods.InitializeQualityObjectActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (InitializeQualityObjectActions), res, (DCObject) qualityTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus InitializeQualityObjectActions()
    {
      return this.InitializeQualityObjectActions((QualityTxn) null, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus InitializeQualityObjectActions(QualityTxn qualityTxn)
    {
      return this.InitializeQualityObjectActions(qualityTxn, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus InitializeQualityObjectActions(
      QualityTxn qualityTxn,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      return this.InitializeQualityObjectActions(qualityTxn, (QualityTxn_Parameters) null, request, out result);
    }

    public ResultStatus InitializeQualityObjectActions_User(
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      result = (QualityTxn_Result) null;
      this.OnBeforeCall(nameof (InitializeQualityObjectActions_User), (DCObject) qualityTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQualityTxnService) this._Channel).InitializeQualityObjectActions_User(this._UserProfile, qualityTxn, parameters, request, out result) : this.AddMethod((Method) new QualityTxnMethod(qualityTxn, QualityTxnMethods.InitializeQualityObjectActions_User, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (InitializeQualityObjectActions_User), res, (DCObject) qualityTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus InitializeQualityObjectActions_User()
    {
      return this.InitializeQualityObjectActions_User((QualityTxn) null, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus InitializeQualityObjectActions_User(QualityTxn qualityTxn)
    {
      return this.InitializeQualityObjectActions_User(qualityTxn, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus InitializeQualityObjectActions_User(
      QualityTxn qualityTxn,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      return this.InitializeQualityObjectActions_User(qualityTxn, (QualityTxn_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      result = (QualityTxn_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) qualityTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQualityTxnService) this._Channel).Load(this._UserProfile, qualityTxn, parameters, request, out result) : this.AddMethod((Method) new QualityTxnMethod(qualityTxn, QualityTxnMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) qualityTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((QualityTxn) null, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus Load(QualityTxn qualityTxn)
    {
      return this.Load(qualityTxn, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus Load(
      QualityTxn qualityTxn,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      return this.Load(qualityTxn, (QualityTxn_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      result = (QualityTxn_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) qualityTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQualityTxnService) this._Channel).LoadESigDetails(this._UserProfile, qualityTxn, parameters, request, out result) : this.AddMethod((Method) new QualityTxnMethod(qualityTxn, QualityTxnMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) qualityTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((QualityTxn) null, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus LoadESigDetails(QualityTxn qualityTxn)
    {
      return this.LoadESigDetails(qualityTxn, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus LoadESigDetails(
      QualityTxn qualityTxn,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      return this.LoadESigDetails(qualityTxn, (QualityTxn_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      result = (QualityTxn_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) qualityTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQualityTxnService) this._Channel).ProcessComputation(this._UserProfile, qualityTxn, parameters, request, out result) : this.AddMethod((Method) new QualityTxnMethod(qualityTxn, QualityTxnMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) qualityTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((QualityTxn) null, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus ProcessComputation(QualityTxn qualityTxn)
    {
      return this.ProcessComputation(qualityTxn, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus ProcessComputation(
      QualityTxn qualityTxn,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      return this.ProcessComputation(qualityTxn, (QualityTxn_Parameters) null, request, out result);
    }

    public ResultStatus RemoveAction(
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      result = (QualityTxn_Result) null;
      this.OnBeforeCall(nameof (RemoveAction), (DCObject) qualityTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQualityTxnService) this._Channel).RemoveAction(this._UserProfile, qualityTxn, parameters, request, out result) : this.AddMethod((Method) new QualityTxnMethod(qualityTxn, QualityTxnMethods.RemoveAction, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (RemoveAction), res, (DCObject) qualityTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus RemoveAction()
    {
      return this.RemoveAction((QualityTxn) null, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus RemoveAction(QualityTxn qualityTxn)
    {
      return this.RemoveAction(qualityTxn, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus RemoveAction(
      QualityTxn qualityTxn,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      return this.RemoveAction(qualityTxn, (QualityTxn_Parameters) null, request, out result);
    }

    public ResultStatus ResolveDataCollectionDef(
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      result = (QualityTxn_Result) null;
      this.OnBeforeCall(nameof (ResolveDataCollectionDef), (DCObject) qualityTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQualityTxnService) this._Channel).ResolveDataCollectionDef(this._UserProfile, qualityTxn, parameters, request, out result) : this.AddMethod((Method) new QualityTxnMethod(qualityTxn, QualityTxnMethods.ResolveDataCollectionDef, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveDataCollectionDef), res, (DCObject) qualityTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveDataCollectionDef()
    {
      return this.ResolveDataCollectionDef((QualityTxn) null, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus ResolveDataCollectionDef(QualityTxn qualityTxn)
    {
      return this.ResolveDataCollectionDef(qualityTxn, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus ResolveDataCollectionDef(
      QualityTxn qualityTxn,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      return this.ResolveDataCollectionDef(qualityTxn, (QualityTxn_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      result = (QualityTxn_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) qualityTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQualityTxnService) this._Channel).ResolveParametricData(this._UserProfile, qualityTxn, parameters, request, out result) : this.AddMethod((Method) new QualityTxnMethod(qualityTxn, QualityTxnMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) qualityTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((QualityTxn) null, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus ResolveParametricData(QualityTxn qualityTxn)
    {
      return this.ResolveParametricData(qualityTxn, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus ResolveParametricData(
      QualityTxn qualityTxn,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      return this.ResolveParametricData(qualityTxn, (QualityTxn_Parameters) null, request, out result);
    }

    public ResultStatus ValidateApprovalStatus(
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      result = (QualityTxn_Result) null;
      this.OnBeforeCall(nameof (ValidateApprovalStatus), (DCObject) qualityTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQualityTxnService) this._Channel).ValidateApprovalStatus(this._UserProfile, qualityTxn, parameters, request, out result) : this.AddMethod((Method) new QualityTxnMethod(qualityTxn, QualityTxnMethods.ValidateApprovalStatus, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateApprovalStatus), res, (DCObject) qualityTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateApprovalStatus()
    {
      return this.ValidateApprovalStatus((QualityTxn) null, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus ValidateApprovalStatus(QualityTxn qualityTxn)
    {
      return this.ValidateApprovalStatus(qualityTxn, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus ValidateApprovalStatus(
      QualityTxn qualityTxn,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      return this.ValidateApprovalStatus(qualityTxn, (QualityTxn_Parameters) null, request, out result);
    }

    public ResultStatus ValidateAvailable(
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      result = (QualityTxn_Result) null;
      this.OnBeforeCall(nameof (ValidateAvailable), (DCObject) qualityTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQualityTxnService) this._Channel).ValidateAvailable(this._UserProfile, qualityTxn, parameters, request, out result) : this.AddMethod((Method) new QualityTxnMethod(qualityTxn, QualityTxnMethods.ValidateAvailable, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateAvailable), res, (DCObject) qualityTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateAvailable()
    {
      return this.ValidateAvailable((QualityTxn) null, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus ValidateAvailable(QualityTxn qualityTxn)
    {
      return this.ValidateAvailable(qualityTxn, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus ValidateAvailable(
      QualityTxn qualityTxn,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      return this.ValidateAvailable(qualityTxn, (QualityTxn_Parameters) null, request, out result);
    }

    public ResultStatus ValidateEmployeeRoleCombination(
      QualityTxn qualityTxn,
      QualityTxn_ValidateEmployeeRoleCombination_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      result = (QualityTxn_Result) null;
      this.OnBeforeCall(nameof (ValidateEmployeeRoleCombination), (DCObject) qualityTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQualityTxnService) this._Channel).ValidateEmployeeRoleCombination(this._UserProfile, qualityTxn, parameters, request, out result) : this.AddMethod((Method) new QualityTxnMethod(qualityTxn, QualityTxnMethods.ValidateEmployeeRoleCombination, (QualityTxn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateEmployeeRoleCombination), res, (DCObject) qualityTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateEmployeeRoleCombination()
    {
      return this.ValidateEmployeeRoleCombination((QualityTxn) null, (QualityTxn_ValidateEmployeeRoleCombination_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus ValidateEmployeeRoleCombination(QualityTxn qualityTxn)
    {
      return this.ValidateEmployeeRoleCombination(qualityTxn, (QualityTxn_ValidateEmployeeRoleCombination_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus ValidateEmployeeRoleCombination(
      QualityTxn qualityTxn,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      return this.ValidateEmployeeRoleCombination(qualityTxn, (QualityTxn_ValidateEmployeeRoleCombination_Parameters) null, request, out result);
    }

    public ResultStatus ValidateOwnerAssigned(
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      result = (QualityTxn_Result) null;
      this.OnBeforeCall(nameof (ValidateOwnerAssigned), (DCObject) qualityTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQualityTxnService) this._Channel).ValidateOwnerAssigned(this._UserProfile, qualityTxn, parameters, request, out result) : this.AddMethod((Method) new QualityTxnMethod(qualityTxn, QualityTxnMethods.ValidateOwnerAssigned, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateOwnerAssigned), res, (DCObject) qualityTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateOwnerAssigned()
    {
      return this.ValidateOwnerAssigned((QualityTxn) null, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus ValidateOwnerAssigned(QualityTxn qualityTxn)
    {
      return this.ValidateOwnerAssigned(qualityTxn, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus ValidateOwnerAssigned(
      QualityTxn qualityTxn,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      return this.ValidateOwnerAssigned(qualityTxn, (QualityTxn_Parameters) null, request, out result);
    }

    public ResultStatus ValidatePendingStatus(
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      result = (QualityTxn_Result) null;
      this.OnBeforeCall(nameof (ValidatePendingStatus), (DCObject) qualityTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQualityTxnService) this._Channel).ValidatePendingStatus(this._UserProfile, qualityTxn, parameters, request, out result) : this.AddMethod((Method) new QualityTxnMethod(qualityTxn, QualityTxnMethods.ValidatePendingStatus, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidatePendingStatus), res, (DCObject) qualityTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidatePendingStatus()
    {
      return this.ValidatePendingStatus((QualityTxn) null, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus ValidatePendingStatus(QualityTxn qualityTxn)
    {
      return this.ValidatePendingStatus(qualityTxn, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus ValidatePendingStatus(
      QualityTxn qualityTxn,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      return this.ValidatePendingStatus(qualityTxn, (QualityTxn_Parameters) null, request, out result);
    }

    public ResultStatus ValidatePermissions(
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      result = (QualityTxn_Result) null;
      this.OnBeforeCall(nameof (ValidatePermissions), (DCObject) qualityTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQualityTxnService) this._Channel).ValidatePermissions(this._UserProfile, qualityTxn, parameters, request, out result) : this.AddMethod((Method) new QualityTxnMethod(qualityTxn, QualityTxnMethods.ValidatePermissions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidatePermissions), res, (DCObject) qualityTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidatePermissions()
    {
      return this.ValidatePermissions((QualityTxn) null, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus ValidatePermissions(QualityTxn qualityTxn)
    {
      return this.ValidatePermissions(qualityTxn, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus ValidatePermissions(
      QualityTxn qualityTxn,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      return this.ValidatePermissions(qualityTxn, (QualityTxn_Parameters) null, request, out result);
    }

    public ResultStatus ValidateQualityObjectStatus(
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      result = (QualityTxn_Result) null;
      this.OnBeforeCall(nameof (ValidateQualityObjectStatus), (DCObject) qualityTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQualityTxnService) this._Channel).ValidateQualityObjectStatus(this._UserProfile, qualityTxn, parameters, request, out result) : this.AddMethod((Method) new QualityTxnMethod(qualityTxn, QualityTxnMethods.ValidateQualityObjectStatus, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateQualityObjectStatus), res, (DCObject) qualityTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateQualityObjectStatus()
    {
      return this.ValidateQualityObjectStatus((QualityTxn) null, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus ValidateQualityObjectStatus(QualityTxn qualityTxn)
    {
      return this.ValidateQualityObjectStatus(qualityTxn, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus ValidateQualityObjectStatus(
      QualityTxn qualityTxn,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      return this.ValidateQualityObjectStatus(qualityTxn, (QualityTxn_Parameters) null, request, out result);
    }

    public ResultStatus ValidateUserAccess(
      QualityTxn qualityTxn,
      QualityTxn_Parameters parameters,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      result = (QualityTxn_Result) null;
      this.OnBeforeCall(nameof (ValidateUserAccess), (DCObject) qualityTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQualityTxnService) this._Channel).ValidateUserAccess(this._UserProfile, qualityTxn, parameters, request, out result) : this.AddMethod((Method) new QualityTxnMethod(qualityTxn, QualityTxnMethods.ValidateUserAccess, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateUserAccess), res, (DCObject) qualityTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateUserAccess()
    {
      return this.ValidateUserAccess((QualityTxn) null, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus ValidateUserAccess(QualityTxn qualityTxn)
    {
      return this.ValidateUserAccess(qualityTxn, (QualityTxn_Parameters) null, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus ValidateUserAccess(
      QualityTxn qualityTxn,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      return this.ValidateUserAccess(qualityTxn, (QualityTxn_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject qualityTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        QualityTxn_Result result1;
        ResultStatus parametricData = this.CreateParametricData((QualityTxn) qualityTxn, (QualityTxn_Parameters) parameters, (QualityTxn_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject qualityTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        QualityTxn_Result result1;
        ResultStatus actions = this.GetActions((QualityTxn) qualityTxn, (QualityTxn_Parameters) parameters, (QualityTxn_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject qualityTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        QualityTxn_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((QualityTxn) qualityTxn, (QualityTxn_Parameters) parameters, (QualityTxn_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject qualityTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        QualityTxn_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((QualityTxn) qualityTxn, (QualityTxn_Parameters) parameters, (QualityTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject qualityTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        QualityTxn_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((QualityTxn) qualityTxn, (QualityTxn_Parameters) parameters, (QualityTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject qualityTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        QualityTxn_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((QualityTxn) qualityTxn, (QualityTxn_Parameters) parameters, (QualityTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject qualityTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        QualityTxn_Result result1;
        ResultStatus resultStatus = this.Load((QualityTxn) qualityTxn, (QualityTxn_Parameters) parameters, (QualityTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject qualityTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        QualityTxn_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((QualityTxn) qualityTxn, (QualityTxn_Parameters) parameters, (QualityTxn_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      result = (QualityTxn_Result) null;
      try
      {
        QualityTxnMethod[] methods = new QualityTxnMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IQualityTxnService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCommitTransaction(
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        QualityTxn_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((QualityTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      QualityTxn cdo,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      result = (QualityTxn_Result) null;
      try
      {
        return ((IQualityTxnService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetEnvironment(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        QualityTxn_Result result1;
        ResultStatus environment = this.GetEnvironment((QualityTxn) cdo, (QualityTxn_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      return this.GetEnvironment((QualityTxn) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      QualityTxn cdo,
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      result = (QualityTxn_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQualityTxnService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new QualityTxnMethod(cdo, QualityTxnMethods.ExecuteTransaction, (QualityTxn_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteTransaction), res, (DCObject) cdo, (Parameters) null, (Request) request, (Result) result);
      return res;
    }

    protected override ResultStatus OnExecuteTransaction(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        QualityTxn_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((QualityTxn) cdo, (QualityTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(QualityTxn cdo)
    {
      return this.ExecuteTransaction(cdo, (QualityTxn_Request) null, out QualityTxn_Result _);
    }

    public ResultStatus ExecuteTransaction(
      QualityTxn_Request request,
      out QualityTxn_Result result)
    {
      return this.ExecuteTransaction((QualityTxn) null, request, out result);
    }

    public ResultStatus AddDataTransaction(QualityTxn cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new QualityTxnMethod(cdo, QualityTxnMethods.AddDataTransaction, (QualityTxn_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
      {
        Result result;
        this.OnAfterCall(nameof (AddDataTransaction), res, (DCObject) cdo, (Parameters) null, (Request) null, result);
      }
      return res;
    }

    protected override ResultStatus OnAddDataTransaction(DCObject cdo)
    {
      try
      {
        return this.AddDataTransaction((QualityTxn) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
