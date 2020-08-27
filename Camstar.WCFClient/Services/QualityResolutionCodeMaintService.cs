// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.QualityResolutionCodeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class QualityResolutionCodeMaintService : UserCodeMaintBase
  {
    public QualityResolutionCodeMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IQualityResolutionCodeMaintService), userProfile);
    }

    public ResultStatus Delete(
      QualityResolutionCodeMaint qualityResolutionCodeMaint,
      QualityResolutionCodeMaint_Parameters parameters,
      QualityResolutionCodeMaint_Request request,
      out QualityResolutionCodeMaint_Result result)
    {
      result = (QualityResolutionCodeMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) qualityResolutionCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQualityResolutionCodeMaintService) this._Channel).Delete(this._UserProfile, qualityResolutionCodeMaint, parameters, request, out result) : this.AddMethod((Method) new QualityResolutionCodeMaintMethod(qualityResolutionCodeMaint, QualityResolutionCodeMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) qualityResolutionCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((QualityResolutionCodeMaint) null, (QualityResolutionCodeMaint_Parameters) null, (QualityResolutionCodeMaint_Request) null, out QualityResolutionCodeMaint_Result _);
    }

    public ResultStatus Delete(
      QualityResolutionCodeMaint qualityResolutionCodeMaint)
    {
      return this.Delete(qualityResolutionCodeMaint, (QualityResolutionCodeMaint_Parameters) null, (QualityResolutionCodeMaint_Request) null, out QualityResolutionCodeMaint_Result _);
    }

    public ResultStatus Delete(
      QualityResolutionCodeMaint qualityResolutionCodeMaint,
      QualityResolutionCodeMaint_Request request,
      out QualityResolutionCodeMaint_Result result)
    {
      return this.Delete(qualityResolutionCodeMaint, (QualityResolutionCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      QualityResolutionCodeMaint qualityResolutionCodeMaint,
      QualityResolutionCodeMaint_Parameters parameters,
      QualityResolutionCodeMaint_Request request,
      out QualityResolutionCodeMaint_Result result)
    {
      result = (QualityResolutionCodeMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) qualityResolutionCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQualityResolutionCodeMaintService) this._Channel).Freeze(this._UserProfile, qualityResolutionCodeMaint, parameters, request, out result) : this.AddMethod((Method) new QualityResolutionCodeMaintMethod(qualityResolutionCodeMaint, QualityResolutionCodeMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) qualityResolutionCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((QualityResolutionCodeMaint) null, (QualityResolutionCodeMaint_Parameters) null, (QualityResolutionCodeMaint_Request) null, out QualityResolutionCodeMaint_Result _);
    }

    public ResultStatus Freeze(
      QualityResolutionCodeMaint qualityResolutionCodeMaint)
    {
      return this.Freeze(qualityResolutionCodeMaint, (QualityResolutionCodeMaint_Parameters) null, (QualityResolutionCodeMaint_Request) null, out QualityResolutionCodeMaint_Result _);
    }

    public ResultStatus Freeze(
      QualityResolutionCodeMaint qualityResolutionCodeMaint,
      QualityResolutionCodeMaint_Request request,
      out QualityResolutionCodeMaint_Result result)
    {
      return this.Freeze(qualityResolutionCodeMaint, (QualityResolutionCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      QualityResolutionCodeMaint qualityResolutionCodeMaint,
      QualityResolutionCodeMaint_Parameters parameters,
      QualityResolutionCodeMaint_Request request,
      out QualityResolutionCodeMaint_Result result)
    {
      result = (QualityResolutionCodeMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) qualityResolutionCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQualityResolutionCodeMaintService) this._Channel).GetWIPMsgs(this._UserProfile, qualityResolutionCodeMaint, parameters, request, out result) : this.AddMethod((Method) new QualityResolutionCodeMaintMethod(qualityResolutionCodeMaint, QualityResolutionCodeMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) qualityResolutionCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((QualityResolutionCodeMaint) null, (QualityResolutionCodeMaint_Parameters) null, (QualityResolutionCodeMaint_Request) null, out QualityResolutionCodeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      QualityResolutionCodeMaint qualityResolutionCodeMaint)
    {
      return this.GetWIPMsgs(qualityResolutionCodeMaint, (QualityResolutionCodeMaint_Parameters) null, (QualityResolutionCodeMaint_Request) null, out QualityResolutionCodeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      QualityResolutionCodeMaint qualityResolutionCodeMaint,
      QualityResolutionCodeMaint_Request request,
      out QualityResolutionCodeMaint_Result result)
    {
      return this.GetWIPMsgs(qualityResolutionCodeMaint, (QualityResolutionCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      QualityResolutionCodeMaint qualityResolutionCodeMaint,
      QualityResolutionCodeMaint_Parameters parameters,
      QualityResolutionCodeMaint_Request request,
      out QualityResolutionCodeMaint_Result result)
    {
      result = (QualityResolutionCodeMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) qualityResolutionCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQualityResolutionCodeMaintService) this._Channel).Load(this._UserProfile, qualityResolutionCodeMaint, parameters, request, out result) : this.AddMethod((Method) new QualityResolutionCodeMaintMethod(qualityResolutionCodeMaint, QualityResolutionCodeMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) qualityResolutionCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((QualityResolutionCodeMaint) null, (QualityResolutionCodeMaint_Parameters) null, (QualityResolutionCodeMaint_Request) null, out QualityResolutionCodeMaint_Result _);
    }

    public ResultStatus Load(
      QualityResolutionCodeMaint qualityResolutionCodeMaint)
    {
      return this.Load(qualityResolutionCodeMaint, (QualityResolutionCodeMaint_Parameters) null, (QualityResolutionCodeMaint_Request) null, out QualityResolutionCodeMaint_Result _);
    }

    public ResultStatus Load(
      QualityResolutionCodeMaint qualityResolutionCodeMaint,
      QualityResolutionCodeMaint_Request request,
      out QualityResolutionCodeMaint_Result result)
    {
      return this.Load(qualityResolutionCodeMaint, (QualityResolutionCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      QualityResolutionCodeMaint qualityResolutionCodeMaint,
      QualityResolutionCodeMaint_LoadESigDetails_Parameters parameters,
      QualityResolutionCodeMaint_Request request,
      out QualityResolutionCodeMaint_Result result)
    {
      result = (QualityResolutionCodeMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) qualityResolutionCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQualityResolutionCodeMaintService) this._Channel).LoadESigDetails(this._UserProfile, qualityResolutionCodeMaint, parameters, request, out result) : this.AddMethod((Method) new QualityResolutionCodeMaintMethod(qualityResolutionCodeMaint, QualityResolutionCodeMaintMethods.LoadESigDetails, (QualityResolutionCodeMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) qualityResolutionCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((QualityResolutionCodeMaint) null, (QualityResolutionCodeMaint_LoadESigDetails_Parameters) null, (QualityResolutionCodeMaint_Request) null, out QualityResolutionCodeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      QualityResolutionCodeMaint qualityResolutionCodeMaint)
    {
      return this.LoadESigDetails(qualityResolutionCodeMaint, (QualityResolutionCodeMaint_LoadESigDetails_Parameters) null, (QualityResolutionCodeMaint_Request) null, out QualityResolutionCodeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      QualityResolutionCodeMaint qualityResolutionCodeMaint,
      QualityResolutionCodeMaint_Request request,
      out QualityResolutionCodeMaint_Result result)
    {
      return this.LoadESigDetails(qualityResolutionCodeMaint, (QualityResolutionCodeMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      QualityResolutionCodeMaint qualityResolutionCodeMaint,
      QualityResolutionCodeMaint_Parameters parameters,
      QualityResolutionCodeMaint_Request request,
      out QualityResolutionCodeMaint_Result result)
    {
      result = (QualityResolutionCodeMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) qualityResolutionCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQualityResolutionCodeMaintService) this._Channel).New(this._UserProfile, qualityResolutionCodeMaint, parameters, request, out result) : this.AddMethod((Method) new QualityResolutionCodeMaintMethod(qualityResolutionCodeMaint, QualityResolutionCodeMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) qualityResolutionCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((QualityResolutionCodeMaint) null, (QualityResolutionCodeMaint_Parameters) null, (QualityResolutionCodeMaint_Request) null, out QualityResolutionCodeMaint_Result _);
    }

    public ResultStatus New(
      QualityResolutionCodeMaint qualityResolutionCodeMaint)
    {
      return this.New(qualityResolutionCodeMaint, (QualityResolutionCodeMaint_Parameters) null, (QualityResolutionCodeMaint_Request) null, out QualityResolutionCodeMaint_Result _);
    }

    public ResultStatus New(
      QualityResolutionCodeMaint qualityResolutionCodeMaint,
      QualityResolutionCodeMaint_Request request,
      out QualityResolutionCodeMaint_Result result)
    {
      return this.New(qualityResolutionCodeMaint, (QualityResolutionCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      QualityResolutionCodeMaint qualityResolutionCodeMaint,
      QualityResolutionCodeMaint_Parameters parameters,
      QualityResolutionCodeMaint_Request request,
      out QualityResolutionCodeMaint_Result result)
    {
      result = (QualityResolutionCodeMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) qualityResolutionCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQualityResolutionCodeMaintService) this._Channel).NewCopy(this._UserProfile, qualityResolutionCodeMaint, parameters, request, out result) : this.AddMethod((Method) new QualityResolutionCodeMaintMethod(qualityResolutionCodeMaint, QualityResolutionCodeMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) qualityResolutionCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((QualityResolutionCodeMaint) null, (QualityResolutionCodeMaint_Parameters) null, (QualityResolutionCodeMaint_Request) null, out QualityResolutionCodeMaint_Result _);
    }

    public ResultStatus NewCopy(
      QualityResolutionCodeMaint qualityResolutionCodeMaint)
    {
      return this.NewCopy(qualityResolutionCodeMaint, (QualityResolutionCodeMaint_Parameters) null, (QualityResolutionCodeMaint_Request) null, out QualityResolutionCodeMaint_Result _);
    }

    public ResultStatus NewCopy(
      QualityResolutionCodeMaint qualityResolutionCodeMaint,
      QualityResolutionCodeMaint_Request request,
      out QualityResolutionCodeMaint_Result result)
    {
      return this.NewCopy(qualityResolutionCodeMaint, (QualityResolutionCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      QualityResolutionCodeMaint qualityResolutionCodeMaint,
      QualityResolutionCodeMaint_Parameters parameters,
      QualityResolutionCodeMaint_Request request,
      out QualityResolutionCodeMaint_Result result)
    {
      result = (QualityResolutionCodeMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) qualityResolutionCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQualityResolutionCodeMaintService) this._Channel).SaveAs(this._UserProfile, qualityResolutionCodeMaint, parameters, request, out result) : this.AddMethod((Method) new QualityResolutionCodeMaintMethod(qualityResolutionCodeMaint, QualityResolutionCodeMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) qualityResolutionCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((QualityResolutionCodeMaint) null, (QualityResolutionCodeMaint_Parameters) null, (QualityResolutionCodeMaint_Request) null, out QualityResolutionCodeMaint_Result _);
    }

    public ResultStatus SaveAs(
      QualityResolutionCodeMaint qualityResolutionCodeMaint)
    {
      return this.SaveAs(qualityResolutionCodeMaint, (QualityResolutionCodeMaint_Parameters) null, (QualityResolutionCodeMaint_Request) null, out QualityResolutionCodeMaint_Result _);
    }

    public ResultStatus SaveAs(
      QualityResolutionCodeMaint qualityResolutionCodeMaint,
      QualityResolutionCodeMaint_Request request,
      out QualityResolutionCodeMaint_Result result)
    {
      return this.SaveAs(qualityResolutionCodeMaint, (QualityResolutionCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      QualityResolutionCodeMaint qualityResolutionCodeMaint,
      QualityResolutionCodeMaint_Parameters parameters,
      QualityResolutionCodeMaint_Request request,
      out QualityResolutionCodeMaint_Result result)
    {
      result = (QualityResolutionCodeMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) qualityResolutionCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQualityResolutionCodeMaintService) this._Channel).UnFreeze(this._UserProfile, qualityResolutionCodeMaint, parameters, request, out result) : this.AddMethod((Method) new QualityResolutionCodeMaintMethod(qualityResolutionCodeMaint, QualityResolutionCodeMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) qualityResolutionCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((QualityResolutionCodeMaint) null, (QualityResolutionCodeMaint_Parameters) null, (QualityResolutionCodeMaint_Request) null, out QualityResolutionCodeMaint_Result _);
    }

    public ResultStatus UnFreeze(
      QualityResolutionCodeMaint qualityResolutionCodeMaint)
    {
      return this.UnFreeze(qualityResolutionCodeMaint, (QualityResolutionCodeMaint_Parameters) null, (QualityResolutionCodeMaint_Request) null, out QualityResolutionCodeMaint_Result _);
    }

    public ResultStatus UnFreeze(
      QualityResolutionCodeMaint qualityResolutionCodeMaint,
      QualityResolutionCodeMaint_Request request,
      out QualityResolutionCodeMaint_Result result)
    {
      return this.UnFreeze(qualityResolutionCodeMaint, (QualityResolutionCodeMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject qualityResolutionCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        QualityResolutionCodeMaint_Result result1;
        ResultStatus resultStatus = this.Delete((QualityResolutionCodeMaint) qualityResolutionCodeMaint, (QualityResolutionCodeMaint_Parameters) parameters, (QualityResolutionCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject qualityResolutionCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        QualityResolutionCodeMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((QualityResolutionCodeMaint) qualityResolutionCodeMaint, (QualityResolutionCodeMaint_Parameters) parameters, (QualityResolutionCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject qualityResolutionCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        QualityResolutionCodeMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((QualityResolutionCodeMaint) qualityResolutionCodeMaint, (QualityResolutionCodeMaint_LoadESigDetails_Parameters) parameters, (QualityResolutionCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject qualityResolutionCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        QualityResolutionCodeMaint_Result result1;
        ResultStatus resultStatus = this.New((QualityResolutionCodeMaint) qualityResolutionCodeMaint, (QualityResolutionCodeMaint_Parameters) parameters, (QualityResolutionCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject qualityResolutionCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        QualityResolutionCodeMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((QualityResolutionCodeMaint) qualityResolutionCodeMaint, (QualityResolutionCodeMaint_Parameters) parameters, (QualityResolutionCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject qualityResolutionCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        QualityResolutionCodeMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((QualityResolutionCodeMaint) qualityResolutionCodeMaint, (QualityResolutionCodeMaint_Parameters) parameters, (QualityResolutionCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject qualityResolutionCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        QualityResolutionCodeMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((QualityResolutionCodeMaint) qualityResolutionCodeMaint, (QualityResolutionCodeMaint_Parameters) parameters, (QualityResolutionCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject qualityResolutionCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        QualityResolutionCodeMaint_Result result1;
        ResultStatus resultStatus = this.Load((QualityResolutionCodeMaint) qualityResolutionCodeMaint, (QualityResolutionCodeMaint_Parameters) parameters, (QualityResolutionCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject qualityResolutionCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        QualityResolutionCodeMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((QualityResolutionCodeMaint) qualityResolutionCodeMaint, (QualityResolutionCodeMaint_Parameters) parameters, (QualityResolutionCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      QualityResolutionCodeMaint_Request request,
      out QualityResolutionCodeMaint_Result result)
    {
      result = (QualityResolutionCodeMaint_Result) null;
      try
      {
        QualityResolutionCodeMaintMethod[] methods = new QualityResolutionCodeMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IQualityResolutionCodeMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        QualityResolutionCodeMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((QualityResolutionCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      QualityResolutionCodeMaint cdo,
      QualityResolutionCodeMaint_Request request,
      out QualityResolutionCodeMaint_Result result)
    {
      result = (QualityResolutionCodeMaint_Result) null;
      try
      {
        return ((IQualityResolutionCodeMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        QualityResolutionCodeMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((QualityResolutionCodeMaint) cdo, (QualityResolutionCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      QualityResolutionCodeMaint_Request request,
      out QualityResolutionCodeMaint_Result result)
    {
      return this.GetEnvironment((QualityResolutionCodeMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      QualityResolutionCodeMaint cdo,
      QualityResolutionCodeMaint_Request request,
      out QualityResolutionCodeMaint_Result result)
    {
      result = (QualityResolutionCodeMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQualityResolutionCodeMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new QualityResolutionCodeMaintMethod(cdo, QualityResolutionCodeMaintMethods.ExecuteTransaction, (QualityResolutionCodeMaint_Parameters) null));
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
        QualityResolutionCodeMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((QualityResolutionCodeMaint) cdo, (QualityResolutionCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(QualityResolutionCodeMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (QualityResolutionCodeMaint_Request) null, out QualityResolutionCodeMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      QualityResolutionCodeMaint_Request request,
      out QualityResolutionCodeMaint_Result result)
    {
      return this.ExecuteTransaction((QualityResolutionCodeMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(QualityResolutionCodeMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new QualityResolutionCodeMaintMethod(cdo, QualityResolutionCodeMaintMethods.AddDataTransaction, (QualityResolutionCodeMaint_Parameters) null));
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
        return this.AddDataTransaction((QualityResolutionCodeMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
