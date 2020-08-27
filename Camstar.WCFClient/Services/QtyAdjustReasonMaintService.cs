// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.QtyAdjustReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class QtyAdjustReasonMaintService : UserCodeMaintBase
  {
    public QtyAdjustReasonMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IQtyAdjustReasonMaintService), userProfile);
    }

    public ResultStatus Delete(
      QtyAdjustReasonMaint qtyAdjustReasonMaint,
      QtyAdjustReasonMaint_Parameters parameters,
      QtyAdjustReasonMaint_Request request,
      out QtyAdjustReasonMaint_Result result)
    {
      result = (QtyAdjustReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) qtyAdjustReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQtyAdjustReasonMaintService) this._Channel).Delete(this._UserProfile, qtyAdjustReasonMaint, parameters, request, out result) : this.AddMethod((Method) new QtyAdjustReasonMaintMethod(qtyAdjustReasonMaint, QtyAdjustReasonMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) qtyAdjustReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((QtyAdjustReasonMaint) null, (QtyAdjustReasonMaint_Parameters) null, (QtyAdjustReasonMaint_Request) null, out QtyAdjustReasonMaint_Result _);
    }

    public ResultStatus Delete(QtyAdjustReasonMaint qtyAdjustReasonMaint)
    {
      return this.Delete(qtyAdjustReasonMaint, (QtyAdjustReasonMaint_Parameters) null, (QtyAdjustReasonMaint_Request) null, out QtyAdjustReasonMaint_Result _);
    }

    public ResultStatus Delete(
      QtyAdjustReasonMaint qtyAdjustReasonMaint,
      QtyAdjustReasonMaint_Request request,
      out QtyAdjustReasonMaint_Result result)
    {
      return this.Delete(qtyAdjustReasonMaint, (QtyAdjustReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      QtyAdjustReasonMaint qtyAdjustReasonMaint,
      QtyAdjustReasonMaint_Parameters parameters,
      QtyAdjustReasonMaint_Request request,
      out QtyAdjustReasonMaint_Result result)
    {
      result = (QtyAdjustReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) qtyAdjustReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQtyAdjustReasonMaintService) this._Channel).Freeze(this._UserProfile, qtyAdjustReasonMaint, parameters, request, out result) : this.AddMethod((Method) new QtyAdjustReasonMaintMethod(qtyAdjustReasonMaint, QtyAdjustReasonMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) qtyAdjustReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((QtyAdjustReasonMaint) null, (QtyAdjustReasonMaint_Parameters) null, (QtyAdjustReasonMaint_Request) null, out QtyAdjustReasonMaint_Result _);
    }

    public ResultStatus Freeze(QtyAdjustReasonMaint qtyAdjustReasonMaint)
    {
      return this.Freeze(qtyAdjustReasonMaint, (QtyAdjustReasonMaint_Parameters) null, (QtyAdjustReasonMaint_Request) null, out QtyAdjustReasonMaint_Result _);
    }

    public ResultStatus Freeze(
      QtyAdjustReasonMaint qtyAdjustReasonMaint,
      QtyAdjustReasonMaint_Request request,
      out QtyAdjustReasonMaint_Result result)
    {
      return this.Freeze(qtyAdjustReasonMaint, (QtyAdjustReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      QtyAdjustReasonMaint qtyAdjustReasonMaint,
      QtyAdjustReasonMaint_Parameters parameters,
      QtyAdjustReasonMaint_Request request,
      out QtyAdjustReasonMaint_Result result)
    {
      result = (QtyAdjustReasonMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) qtyAdjustReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQtyAdjustReasonMaintService) this._Channel).GetWIPMsgs(this._UserProfile, qtyAdjustReasonMaint, parameters, request, out result) : this.AddMethod((Method) new QtyAdjustReasonMaintMethod(qtyAdjustReasonMaint, QtyAdjustReasonMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) qtyAdjustReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((QtyAdjustReasonMaint) null, (QtyAdjustReasonMaint_Parameters) null, (QtyAdjustReasonMaint_Request) null, out QtyAdjustReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(QtyAdjustReasonMaint qtyAdjustReasonMaint)
    {
      return this.GetWIPMsgs(qtyAdjustReasonMaint, (QtyAdjustReasonMaint_Parameters) null, (QtyAdjustReasonMaint_Request) null, out QtyAdjustReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      QtyAdjustReasonMaint qtyAdjustReasonMaint,
      QtyAdjustReasonMaint_Request request,
      out QtyAdjustReasonMaint_Result result)
    {
      return this.GetWIPMsgs(qtyAdjustReasonMaint, (QtyAdjustReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      QtyAdjustReasonMaint qtyAdjustReasonMaint,
      QtyAdjustReasonMaint_Parameters parameters,
      QtyAdjustReasonMaint_Request request,
      out QtyAdjustReasonMaint_Result result)
    {
      result = (QtyAdjustReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) qtyAdjustReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQtyAdjustReasonMaintService) this._Channel).Load(this._UserProfile, qtyAdjustReasonMaint, parameters, request, out result) : this.AddMethod((Method) new QtyAdjustReasonMaintMethod(qtyAdjustReasonMaint, QtyAdjustReasonMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) qtyAdjustReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((QtyAdjustReasonMaint) null, (QtyAdjustReasonMaint_Parameters) null, (QtyAdjustReasonMaint_Request) null, out QtyAdjustReasonMaint_Result _);
    }

    public ResultStatus Load(QtyAdjustReasonMaint qtyAdjustReasonMaint)
    {
      return this.Load(qtyAdjustReasonMaint, (QtyAdjustReasonMaint_Parameters) null, (QtyAdjustReasonMaint_Request) null, out QtyAdjustReasonMaint_Result _);
    }

    public ResultStatus Load(
      QtyAdjustReasonMaint qtyAdjustReasonMaint,
      QtyAdjustReasonMaint_Request request,
      out QtyAdjustReasonMaint_Result result)
    {
      return this.Load(qtyAdjustReasonMaint, (QtyAdjustReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      QtyAdjustReasonMaint qtyAdjustReasonMaint,
      QtyAdjustReasonMaint_LoadESigDetails_Parameters parameters,
      QtyAdjustReasonMaint_Request request,
      out QtyAdjustReasonMaint_Result result)
    {
      result = (QtyAdjustReasonMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) qtyAdjustReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQtyAdjustReasonMaintService) this._Channel).LoadESigDetails(this._UserProfile, qtyAdjustReasonMaint, parameters, request, out result) : this.AddMethod((Method) new QtyAdjustReasonMaintMethod(qtyAdjustReasonMaint, QtyAdjustReasonMaintMethods.LoadESigDetails, (QtyAdjustReasonMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) qtyAdjustReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((QtyAdjustReasonMaint) null, (QtyAdjustReasonMaint_LoadESigDetails_Parameters) null, (QtyAdjustReasonMaint_Request) null, out QtyAdjustReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(QtyAdjustReasonMaint qtyAdjustReasonMaint)
    {
      return this.LoadESigDetails(qtyAdjustReasonMaint, (QtyAdjustReasonMaint_LoadESigDetails_Parameters) null, (QtyAdjustReasonMaint_Request) null, out QtyAdjustReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      QtyAdjustReasonMaint qtyAdjustReasonMaint,
      QtyAdjustReasonMaint_Request request,
      out QtyAdjustReasonMaint_Result result)
    {
      return this.LoadESigDetails(qtyAdjustReasonMaint, (QtyAdjustReasonMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      QtyAdjustReasonMaint qtyAdjustReasonMaint,
      QtyAdjustReasonMaint_Parameters parameters,
      QtyAdjustReasonMaint_Request request,
      out QtyAdjustReasonMaint_Result result)
    {
      result = (QtyAdjustReasonMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) qtyAdjustReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQtyAdjustReasonMaintService) this._Channel).New(this._UserProfile, qtyAdjustReasonMaint, parameters, request, out result) : this.AddMethod((Method) new QtyAdjustReasonMaintMethod(qtyAdjustReasonMaint, QtyAdjustReasonMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) qtyAdjustReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((QtyAdjustReasonMaint) null, (QtyAdjustReasonMaint_Parameters) null, (QtyAdjustReasonMaint_Request) null, out QtyAdjustReasonMaint_Result _);
    }

    public ResultStatus New(QtyAdjustReasonMaint qtyAdjustReasonMaint)
    {
      return this.New(qtyAdjustReasonMaint, (QtyAdjustReasonMaint_Parameters) null, (QtyAdjustReasonMaint_Request) null, out QtyAdjustReasonMaint_Result _);
    }

    public ResultStatus New(
      QtyAdjustReasonMaint qtyAdjustReasonMaint,
      QtyAdjustReasonMaint_Request request,
      out QtyAdjustReasonMaint_Result result)
    {
      return this.New(qtyAdjustReasonMaint, (QtyAdjustReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      QtyAdjustReasonMaint qtyAdjustReasonMaint,
      QtyAdjustReasonMaint_Parameters parameters,
      QtyAdjustReasonMaint_Request request,
      out QtyAdjustReasonMaint_Result result)
    {
      result = (QtyAdjustReasonMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) qtyAdjustReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQtyAdjustReasonMaintService) this._Channel).NewCopy(this._UserProfile, qtyAdjustReasonMaint, parameters, request, out result) : this.AddMethod((Method) new QtyAdjustReasonMaintMethod(qtyAdjustReasonMaint, QtyAdjustReasonMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) qtyAdjustReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((QtyAdjustReasonMaint) null, (QtyAdjustReasonMaint_Parameters) null, (QtyAdjustReasonMaint_Request) null, out QtyAdjustReasonMaint_Result _);
    }

    public ResultStatus NewCopy(QtyAdjustReasonMaint qtyAdjustReasonMaint)
    {
      return this.NewCopy(qtyAdjustReasonMaint, (QtyAdjustReasonMaint_Parameters) null, (QtyAdjustReasonMaint_Request) null, out QtyAdjustReasonMaint_Result _);
    }

    public ResultStatus NewCopy(
      QtyAdjustReasonMaint qtyAdjustReasonMaint,
      QtyAdjustReasonMaint_Request request,
      out QtyAdjustReasonMaint_Result result)
    {
      return this.NewCopy(qtyAdjustReasonMaint, (QtyAdjustReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      QtyAdjustReasonMaint qtyAdjustReasonMaint,
      QtyAdjustReasonMaint_Parameters parameters,
      QtyAdjustReasonMaint_Request request,
      out QtyAdjustReasonMaint_Result result)
    {
      result = (QtyAdjustReasonMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) qtyAdjustReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQtyAdjustReasonMaintService) this._Channel).SaveAs(this._UserProfile, qtyAdjustReasonMaint, parameters, request, out result) : this.AddMethod((Method) new QtyAdjustReasonMaintMethod(qtyAdjustReasonMaint, QtyAdjustReasonMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) qtyAdjustReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((QtyAdjustReasonMaint) null, (QtyAdjustReasonMaint_Parameters) null, (QtyAdjustReasonMaint_Request) null, out QtyAdjustReasonMaint_Result _);
    }

    public ResultStatus SaveAs(QtyAdjustReasonMaint qtyAdjustReasonMaint)
    {
      return this.SaveAs(qtyAdjustReasonMaint, (QtyAdjustReasonMaint_Parameters) null, (QtyAdjustReasonMaint_Request) null, out QtyAdjustReasonMaint_Result _);
    }

    public ResultStatus SaveAs(
      QtyAdjustReasonMaint qtyAdjustReasonMaint,
      QtyAdjustReasonMaint_Request request,
      out QtyAdjustReasonMaint_Result result)
    {
      return this.SaveAs(qtyAdjustReasonMaint, (QtyAdjustReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      QtyAdjustReasonMaint qtyAdjustReasonMaint,
      QtyAdjustReasonMaint_Parameters parameters,
      QtyAdjustReasonMaint_Request request,
      out QtyAdjustReasonMaint_Result result)
    {
      result = (QtyAdjustReasonMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) qtyAdjustReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQtyAdjustReasonMaintService) this._Channel).UnFreeze(this._UserProfile, qtyAdjustReasonMaint, parameters, request, out result) : this.AddMethod((Method) new QtyAdjustReasonMaintMethod(qtyAdjustReasonMaint, QtyAdjustReasonMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) qtyAdjustReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((QtyAdjustReasonMaint) null, (QtyAdjustReasonMaint_Parameters) null, (QtyAdjustReasonMaint_Request) null, out QtyAdjustReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(QtyAdjustReasonMaint qtyAdjustReasonMaint)
    {
      return this.UnFreeze(qtyAdjustReasonMaint, (QtyAdjustReasonMaint_Parameters) null, (QtyAdjustReasonMaint_Request) null, out QtyAdjustReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(
      QtyAdjustReasonMaint qtyAdjustReasonMaint,
      QtyAdjustReasonMaint_Request request,
      out QtyAdjustReasonMaint_Result result)
    {
      return this.UnFreeze(qtyAdjustReasonMaint, (QtyAdjustReasonMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject qtyAdjustReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        QtyAdjustReasonMaint_Result result1;
        ResultStatus resultStatus = this.Delete((QtyAdjustReasonMaint) qtyAdjustReasonMaint, (QtyAdjustReasonMaint_Parameters) parameters, (QtyAdjustReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject qtyAdjustReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        QtyAdjustReasonMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((QtyAdjustReasonMaint) qtyAdjustReasonMaint, (QtyAdjustReasonMaint_Parameters) parameters, (QtyAdjustReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject qtyAdjustReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        QtyAdjustReasonMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((QtyAdjustReasonMaint) qtyAdjustReasonMaint, (QtyAdjustReasonMaint_LoadESigDetails_Parameters) parameters, (QtyAdjustReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject qtyAdjustReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        QtyAdjustReasonMaint_Result result1;
        ResultStatus resultStatus = this.New((QtyAdjustReasonMaint) qtyAdjustReasonMaint, (QtyAdjustReasonMaint_Parameters) parameters, (QtyAdjustReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject qtyAdjustReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        QtyAdjustReasonMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((QtyAdjustReasonMaint) qtyAdjustReasonMaint, (QtyAdjustReasonMaint_Parameters) parameters, (QtyAdjustReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject qtyAdjustReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        QtyAdjustReasonMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((QtyAdjustReasonMaint) qtyAdjustReasonMaint, (QtyAdjustReasonMaint_Parameters) parameters, (QtyAdjustReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject qtyAdjustReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        QtyAdjustReasonMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((QtyAdjustReasonMaint) qtyAdjustReasonMaint, (QtyAdjustReasonMaint_Parameters) parameters, (QtyAdjustReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject qtyAdjustReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        QtyAdjustReasonMaint_Result result1;
        ResultStatus resultStatus = this.Load((QtyAdjustReasonMaint) qtyAdjustReasonMaint, (QtyAdjustReasonMaint_Parameters) parameters, (QtyAdjustReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject qtyAdjustReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        QtyAdjustReasonMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((QtyAdjustReasonMaint) qtyAdjustReasonMaint, (QtyAdjustReasonMaint_Parameters) parameters, (QtyAdjustReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      QtyAdjustReasonMaint_Request request,
      out QtyAdjustReasonMaint_Result result)
    {
      result = (QtyAdjustReasonMaint_Result) null;
      try
      {
        QtyAdjustReasonMaintMethod[] methods = new QtyAdjustReasonMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IQtyAdjustReasonMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        QtyAdjustReasonMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((QtyAdjustReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      QtyAdjustReasonMaint cdo,
      QtyAdjustReasonMaint_Request request,
      out QtyAdjustReasonMaint_Result result)
    {
      result = (QtyAdjustReasonMaint_Result) null;
      try
      {
        return ((IQtyAdjustReasonMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        QtyAdjustReasonMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((QtyAdjustReasonMaint) cdo, (QtyAdjustReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      QtyAdjustReasonMaint_Request request,
      out QtyAdjustReasonMaint_Result result)
    {
      return this.GetEnvironment((QtyAdjustReasonMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      QtyAdjustReasonMaint cdo,
      QtyAdjustReasonMaint_Request request,
      out QtyAdjustReasonMaint_Result result)
    {
      result = (QtyAdjustReasonMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IQtyAdjustReasonMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new QtyAdjustReasonMaintMethod(cdo, QtyAdjustReasonMaintMethods.ExecuteTransaction, (QtyAdjustReasonMaint_Parameters) null));
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
        QtyAdjustReasonMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((QtyAdjustReasonMaint) cdo, (QtyAdjustReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(QtyAdjustReasonMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (QtyAdjustReasonMaint_Request) null, out QtyAdjustReasonMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      QtyAdjustReasonMaint_Request request,
      out QtyAdjustReasonMaint_Result result)
    {
      return this.ExecuteTransaction((QtyAdjustReasonMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(QtyAdjustReasonMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new QtyAdjustReasonMaintMethod(cdo, QtyAdjustReasonMaintMethods.AddDataTransaction, (QtyAdjustReasonMaint_Parameters) null));
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
        return this.AddDataTransaction((QtyAdjustReasonMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
