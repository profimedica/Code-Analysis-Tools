using CodeCollector;

namespace LogsPresenter
{
    class VisualParadigm
    {
    }

    public class VPMessageModel
    {
        private CallElement callElement;

        public VPMessageModel(CallElement callElement)
        {
            // TODO: Complete member initialization
            this.callElement = callElement;
        }

        public string ToString()
        {
            return
"<Model composite=\"false\" considerDefaultProperties=\"false\" displayModelType=\"Message\" id=\"" + callElement.FromMethod.ID + "m" + callElement.ToMethod.ID + "\" modelType=\"Message\" name=\"test\">\r\n" +
/*"			<ModelProperties>\r\n" +
"				<StringProperty displayName=\"Name\" name=\"name\" value=\"" + callElement.ToMethod.Name + "\"/>\r\n" +
"				<StringProperty displayName=\"Model Type\" name=\"modelType\" value=\"Message\"/>\r\n" +
"				<ModelRefProperty displayName=\"End Relationship From Meta Model Element\" name=\"endRelationshipFromMetaModelElement\">\r\n" +
"					<ModelRef id=\"" + callElement.FromMethod.ID + "LifeLine\"/>\r\n" +
"				</ModelRefProperty>\r\n" +
"				<ModelRefProperty displayName=\"End Relationship To Meta Model Element\" name=\"endRelationshipToMetaModelElement\">\r\n" +
"					<ModelRef id=\"" + callElement.ToMethod.ID + "LifeLine\"/>\r\n" +
"				</ModelRefProperty>\r\n" +
"				<ModelsProperty displayName=\"Comments\" name=\"comments\"/>\r\n" +
"				<HTMLProperty displayName=\"Description\" name=\"documentation\" plainTextValue=\"\"/>\r\n" +
"				<ModelsProperty displayName=\"Voices\" name=\"voices\"/>\r\n" +
"				<ModelsProperty displayName=\"References\" name=\"references\"/>\r\n" +
"				<StringArrayProperty displayName=\"Referenced By Diagram Ids\" name=\"referencedByDiagramIds\"/>\r\n" +
"				<StringArrayProperty displayName=\"Referenced By Model Addresses\" name=\"referencedByModelAddresses\"/>\r\n" +
"				<StringProperty displayName=\"Transit From\" name=\"transitFrom\"/>\r\n" +
"				<StringProperty displayName=\"Transit To\" name=\"transitTo\"/>\r\n" +
"				<ModelRefProperty displayName=\"Pm Status\" name=\"pmStatus\"/>\r\n" +
"				<ModelRefProperty displayName=\"Pm Difficulty\" name=\"pmDifficulty\"/>\r\n" +
"				<ModelRefProperty displayName=\"Pm Priority\" name=\"pmPriority\"/>\r\n" +
"				<ModelRefProperty displayName=\"Pm Version\" name=\"pmVersion\"/>\r\n" +
"				<ModelRefProperty displayName=\"Pm Iteration\" name=\"pmIteration\"/>\r\n" +
"				<ModelRefProperty displayName=\"Pm Phase\" name=\"pmPhase\"/>\r\n" +
"				<ModelRefProperty displayName=\"Pm Discipline\" name=\"pmDiscipline\"/>\r\n" +
"				<StringProperty displayName=\"Pm Author\" name=\"pmAuthor\" value=\"CumpanasuF\"/>\r\n" +
"				<StringProperty displayName=\"Pm Create Date Time\" name=\"pmCreateDateTime\" value=\"1463500707713\"/>\r\n" +
"				<StringProperty displayName=\"Pm Last Modified\" name=\"pmLastModified\" value=\"1463500713376\"/>\r\n" +
"				<StringProperty displayName=\"Id\" name=\"userID\"/>\r\n" +
"				<IntegerProperty displayName=\"User IDLast Numeric Value\" name=\"userIDLastNumericValue\" value=\"0\"/>\r\n" +
"				<ModelRefsProperty displayName=\"Stereotypes\" name=\"stereotypes\"/>\r\n" +
"				<ModelProperty displayName=\"Tagged Values\" name=\"taggedValues\"/>\r\n" +
"				<ModelRefsProperty displayName=\"Sync Mapping Models\" name=\"syncMappingModels\"/>\r\n" +
"				<IntegerProperty displayName=\"Quality Score\" name=\"qualityScore\" value=\"-1\"/>\r\n" +
"				<StringProperty displayName=\"Quality Reason\" name=\"qualityReason\"/>\r\n" +
"				<ModelsProperty displayName=\"Arguments\" name=\"arguments\"/>\r\n" +
"				<ModelRefProperty displayName=\"Return Message\" name=\"returnMessage\"/>\r\n" +
"				<ModelRefProperty displayName=\"Branch Parent Message\" name=\"branchParentMessage\"/>\r\n" +
"				<ModelRefProperty displayName=\"From Activation\" name=\"fromActivation\">\r\n" +
"					<ModelRef id=\"KekO_SqGAqBwAZis\"/>\r\n" +
"				</ModelRefProperty>\r\n" +
"				<ModelRefProperty displayName=\"To Activation\" name=\"toActivation\">\r\n" +
"					<ModelRef id=\"mekO_SqGAqBwAZiy\"/>\r\n" +
"				</ModelRefProperty>\r\n" +
"				<IntegerProperty displayName=\"Duration Height\" name=\"durationHeight\" value=\"30\"/>\r\n" +
"				<StringProperty displayName=\"Type\" name=\"type\" value=\"Message\"/>\r\n" +
"				<StringProperty displayName=\"Sequence Number\" name=\"sequenceNumber\" value=\"1\"/>\r\n" +
"				<ModelProperty displayName=\"Action Type\" name=\"actionType\"/>\r\n" +
"				<BooleanProperty displayName=\"Asynchronous\" name=\"asynchronous\" value=\"false\"/>\r\n" +
"				<ModelProperty displayName=\"Return Value\" name=\"returnValue\"/>\r\n" +
"				<DiagramElementRefProperty displayName=\"Master View\" name=\"masterView\">\r\n" +
"					<DiagramElementRef displayShapeType=\"Message\" id=\"oekO_SqGAqBwAZio\" model=\"" + callElement.FromMethod.ID + "m" + callElement.ToMethod.ID + "\" name=\"test\" shapeType=\"Message\"/>\r\n" +
"				</DiagramElementRefProperty>\r\n" +
"			</ModelProperties>\r\n" +
"			<FromEnd>\r\n" +
"				<Model composite=\"true\" considerDefaultProperties=\"false\" displayModelType=\"Message End\" id=\"QekO_SqGAqBwAZim\" modelType=\"MessageEnd\">\r\n" +
"					<ModelProperties>\r\n" +
"						<StringProperty displayName=\"Name\" name=\"name\"/>\r\n" +
"						<StringProperty displayName=\"Model Type\" name=\"modelType\" value=\"MessageEnd\"/>\r\n" +
"						<ModelRefProperty displayName=\"End Model Element\" name=\"EndModelElement\">\r\n" +
"							<ModelRef id=\"" + callElement.FromMethod.ID + "LifeLine\"/>\r\n" +
"						</ModelRefProperty>\r\n" +
"						<ModelsProperty displayName=\"Comments\" name=\"comments\"/>\r\n" +
"						<HTMLProperty displayName=\"Description\" name=\"documentation\" plainTextValue=\"\"/>\r\n" +
"						<ModelsProperty displayName=\"Voices\" name=\"voices\"/>\r\n" +
"						<ModelsProperty displayName=\"References\" name=\"references\"/>\r\n" +
"						<StringArrayProperty displayName=\"Referenced By Diagram Ids\" name=\"referencedByDiagramIds\"/>\r\n" +
"						<StringArrayProperty displayName=\"Referenced By Model Addresses\" name=\"referencedByModelAddresses\"/>\r\n" +
"						<StringProperty displayName=\"Transit From\" name=\"transitFrom\"/>\r\n" +
"						<StringProperty displayName=\"Transit To\" name=\"transitTo\"/>\r\n" +
"						<ModelRefProperty displayName=\"Pm Status\" name=\"pmStatus\"/>\r\n" +
"						<ModelRefProperty displayName=\"Pm Difficulty\" name=\"pmDifficulty\"/>\r\n" +
"						<ModelRefProperty displayName=\"Pm Priority\" name=\"pmPriority\"/>\r\n" +
"						<ModelRefProperty displayName=\"Pm Version\" name=\"pmVersion\"/>\r\n" +
"						<ModelRefProperty displayName=\"Pm Iteration\" name=\"pmIteration\"/>\r\n" +
"						<ModelRefProperty displayName=\"Pm Phase\" name=\"pmPhase\"/>\r\n" +
"						<ModelRefProperty displayName=\"Pm Discipline\" name=\"pmDiscipline\"/>\r\n" +
"						<StringProperty displayName=\"Pm Author\" name=\"pmAuthor\" value=\"CumpanasuF\"/>\r\n" +
"						<StringProperty displayName=\"Pm Create Date Time\" name=\"pmCreateDateTime\" value=\"1463500707714\"/>\r\n" +
"						<StringProperty displayName=\"Pm Last Modified\" name=\"pmLastModified\"/>\r\n" +
"						<StringProperty displayName=\"Id\" name=\"userID\"/>\r\n" +
"						<IntegerProperty displayName=\"User IDLast Numeric Value\" name=\"userIDLastNumericValue\" value=\"0\"/>\r\n" +
"						<ModelRefsProperty displayName=\"Stereotypes\" name=\"stereotypes\"/>\r\n" +
"						<ModelProperty displayName=\"Tagged Values\" name=\"taggedValues\"/>\r\n" +
"						<ModelRefsProperty displayName=\"Sync Mapping Models\" name=\"syncMappingModels\"/>\r\n" +
"						<IntegerProperty displayName=\"Quality Score\" name=\"qualityScore\" value=\"-1\"/>\r\n" +
"						<StringProperty displayName=\"Quality Reason\" name=\"qualityReason\"/>\r\n" +
"					</ModelProperties>\r\n" +
"				</Model>\r\n" +
"			</FromEnd>\r\n" +
"			<ToEnd>\r\n" +
"				<Model composite=\"true\" considerDefaultProperties=\"false\" displayModelType=\"Message End\" id=\"QekO_SqGAqBwAZin\" modelType=\"MessageEnd\">\r\n" +
"					<ModelProperties>\r\n" +
"						<StringProperty displayName=\"Name\" name=\"name\"/>\r\n" +
"						<StringProperty displayName=\"Model Type\" name=\"modelType\" value=\"MessageEnd\"/>\r\n" +
"						<ModelRefProperty displayName=\"End Model Element\" name=\"EndModelElement\">\r\n" +
"							<ModelRef id=\"" + callElement.ToMethod.ID + "LifeLine\"/>\r\n" +
"						</ModelRefProperty>\r\n" +
"						<ModelsProperty displayName=\"Comments\" name=\"comments\"/>\r\n" +
"						<HTMLProperty displayName=\"Description\" name=\"documentation\" plainTextValue=\"\"/>\r\n" +
"						<ModelsProperty displayName=\"Voices\" name=\"voices\"/>\r\n" +
"						<ModelsProperty displayName=\"References\" name=\"references\"/>\r\n" +
"						<StringArrayProperty displayName=\"Referenced By Diagram Ids\" name=\"referencedByDiagramIds\"/>\r\n" +
"						<StringArrayProperty displayName=\"Referenced By Model Addresses\" name=\"referencedByModelAddresses\"/>\r\n" +
"						<StringProperty displayName=\"Transit From\" name=\"transitFrom\"/>\r\n" +
"						<StringProperty displayName=\"Transit To\" name=\"transitTo\"/>\r\n" +
"						<ModelRefProperty displayName=\"Pm Status\" name=\"pmStatus\"/>\r\n" +
"						<ModelRefProperty displayName=\"Pm Difficulty\" name=\"pmDifficulty\"/>\r\n" +
"						<ModelRefProperty displayName=\"Pm Priority\" name=\"pmPriority\"/>\r\n" +
"						<ModelRefProperty displayName=\"Pm Version\" name=\"pmVersion\"/>\r\n" +
"						<ModelRefProperty displayName=\"Pm Iteration\" name=\"pmIteration\"/>\r\n" +
"						<ModelRefProperty displayName=\"Pm Phase\" name=\"pmPhase\"/>\r\n" +
"						<ModelRefProperty displayName=\"Pm Discipline\" name=\"pmDiscipline\"/>\r\n" +
"						<StringProperty displayName=\"Pm Author\" name=\"pmAuthor\" value=\"CumpanasuF\"/>\r\n" +
"						<StringProperty displayName=\"Pm Create Date Time\" name=\"pmCreateDateTime\" value=\"1463500707714\"/>\r\n" +
"						<StringProperty displayName=\"Pm Last Modified\" name=\"pmLastModified\"/>\r\n" +
"						<StringProperty displayName=\"Id\" name=\"userID\"/>\r\n" +
"						<IntegerProperty displayName=\"User IDLast Numeric Value\" name=\"userIDLastNumericValue\" value=\"0\"/>\r\n" +
"						<ModelRefsProperty displayName=\"Stereotypes\" name=\"stereotypes\"/>\r\n" +
"						<ModelProperty displayName=\"Tagged Values\" name=\"taggedValues\"/>\r\n" +
"						<ModelRefsProperty displayName=\"Sync Mapping Models\" name=\"syncMappingModels\"/>\r\n" +
"						<IntegerProperty displayName=\"Quality Score\" name=\"qualityScore\" value=\"-1\"/>\r\n" +
"						<StringProperty displayName=\"Quality Reason\" name=\"qualityReason\"/>\r\n" +
"					</ModelProperties>\r\n" +
"				</Model>\r\n" +
"			</ToEnd>\r\n" + */
"		</Model>\r\n";
        }
    }

    public class VPConnectorModel
    {
        private XClass XClass1;
        private XClass XClass2;
        private CallElement callElement;

        public VPConnectorModel(XClass myClass1, XClass myClass2)
        {
            this.XClass1 = myClass1;
            this.XClass2 = myClass2;
        }

        public VPConnectorModel(CallElement callElement)
        {
            // TODO: Complete member initialization
            this.callElement = callElement;
        }

        public string ToString()
        {
            return
                "				<Connector connectorStyle=\"Follow Diagram\" from=\"" + callElement.FromMethod.Parent.ID + "LifeLineShape\" height=\"100\" id=\"" + callElement.FromMethod.ID + "m" + callElement.ToMethod.ID + "Message\" model=\"" + callElement.FromMethod.ID + "m" + callElement.ToMethod.ID + "\" name=\"ttt\" shapeType=\"Message\" to=\"" + callElement.ToMethod.Parent.ID + "LifeLineShape\" width=\"259\" x=\"471\" y=\"96\" zorder=\"-1\">\r\n"
                +
                "					<DiagramElementProperties>\r\n" +
                "						<IntegerProperty displayName=\"ZOrder\" name=\"zOrder\" value=\"-1\"/>\r\n" +
                "						<ModelRefProperty displayName=\"Meta Model Element\" name=\"metaModelElement\">\r\n" +
                "							<ModelRef id=\"" + callElement.FromMethod.ID + "m" + callElement.ToMethod.ID + "\"/>\r\n" +
                "						</ModelRefProperty>\r\n" +
                /*                "						<ModelRefProperty displayName=\"Style\" name=\"style\"/>\r\n" +
                                "						<IntegerProperty displayName=\"X\" name=\"x\" value=\"471\"/>\r\n" +
                                "						<IntegerProperty displayName=\"Y\" name=\"y\" value=\"96\"/>\r\n" +
                                "						<IntegerProperty displayName=\"Width\" name=\"width\" value=\"259\"/>\r\n" +
                                "						<IntegerProperty displayName=\"Height\" name=\"height\" value=\"100\"/>\r\n" +
                                "						<ColorProperty displayName=\"Background\" name=\"background\" value=\"Cr:0,0,0,255\"/>\r\n" +
                                "						<ColorProperty displayName=\"Foreground\" name=\"foreground\" value=\"Cr:0,0,0,255\"/>\r\n" +
                                "						<StringProperty displayName=\"Creator Diagram Type\" name=\"creatorDiagramType\"/>\r\n" +
                                "						<BooleanProperty displayName=\"Selectable\" name=\"selectable\" value=\"true\"/>\r\n" +
                                "						<BooleanProperty displayName=\"Request Reset Caption\" name=\"requestResetCaption\" value=\"false\"/>\r\n" +
                                "						<BooleanProperty displayName=\"Request Reset Caption Size\" name=\"requestResetCaptionSize\" value=\"false\"/>\r\n"
                                +
                                "						<BooleanProperty displayName=\"Request Reset Caption Fit Width\" name=\"requestResetCaptionFitWidth\" value=\"false\"/>\r\n"
                                +
                                "						<StringArrayProperty displayName=\"Referenced By Diagram Ids\" name=\"referencedByDiagramIds\"/>\r\n" +
                                "						<StringArrayProperty displayName=\"Referenced By Model Addresses\" name=\"referencedByModelAddresses\"/>\r\n"
                                +
                                "						<StringProperty displayName=\"From Member Id\" name=\"fromMemberId\"/>\r\n" +
                                "						<StringProperty displayName=\"To Member Id\" name=\"toMemberId\"/>\r\n" +
                                "						<IntegerProperty displayName=\"Connector Style\" name=\"connectorStyle\" value=\"3\"/>\r\n" +
                                "						<IntegerProperty displayName=\"Connector Line Jumps\" name=\"connectorLineJumps\" value=\"4\"/>\r\n" +
                                "						<IntegerProperty displayName=\"Connector Label Orientation\" name=\"connectorLabelOrientation\" value=\"4\"/>\r\n"
                                +
                                "						<IntegerProperty displayName=\"From Shape XDiff\" name=\"fromShapeXDiff\" value=\"0\"/>\r\n" +
                                "						<IntegerProperty displayName=\"From Shape YDiff\" name=\"fromShapeYDiff\" value=\"0\"/>\r\n" +
                                "						<IntegerProperty displayName=\"To Shape XDiff\" name=\"toShapeXDiff\" value=\"0\"/>\r\n" +
                                "						<IntegerProperty displayName=\"To Shape YDiff\" name=\"toShapeYDiff\" value=\"0\"/>\r\n" +
                                "						<IntegerProperty displayName=\"From Connect Type\" name=\"fromConnectType\" value=\"0\"/>\r\n" +
                                "						<IntegerProperty displayName=\"To Connect Type\" name=\"toConnectType\" value=\"0\"/>\r\n" +
                                "						<BooleanProperty displayName=\"Use From Shape Center\" name=\"useFromShapeCenter\" value=\"true\"/>\r\n" +
                                "						<BooleanProperty displayName=\"Use To Shape Center\" name=\"useToShapeCenter\" value=\"true\"/>\r\n" +
                                "						<IntegerProperty displayName=\"From Pin Type\" name=\"fromPinType\" value=\"1\"/>\r\n" +
                                "						<IntegerProperty displayName=\"To Pin Type\" name=\"toPinType\" value=\"1\"/>\r\n" +
                                "						<PointProperty displayName=\"From Pin Ratio\" name=\"fromPinRatio\" value=\"\"/>\r\n" +
                                "						<PointProperty displayName=\"To Pin Ratio\" name=\"toPinRatio\" value=\"\"/>\r\n" +
                                "						<BooleanProperty displayName=\"Request Rebuild\" name=\"requestRebuild\" value=\"false\"/>\r\n" +
                                "						<IntegerProperty displayName=\"Show Connector Name\" name=\"showConnectorName\" value=\"2\"/>\r\n" +
                                "						<IntegerProperty displayName=\"Paint Through Label\" name=\"paintThroughLabel\" value=\"2\"/>\r\n" +
                                "						<BooleanProperty displayName=\"Folded\" name=\"folded\" value=\"false\"/>\r\n" +
                                "						<IntegerProperty displayName=\"Show Parameter Names In Message Operation Signature\" name=\"showParameterNamesInMessageOperationSignature\" value=\"0\"/>\r\n"
                                +
                                "						<IntegerProperty displayName=\"Show Parameter Types In Message Operation Signature\" name=\"showParameterTypesInMessageOperationSignature\" value=\"0\"/>\r\n"
                                +
                                "						<IntegerProperty displayName=\"Show Arguments In Message Operation Signature\" name=\"showArgumentsInMessageOperationSignature\" value=\"0\"/>\r\n"
                                +
                                "						<IntegerProperty displayName=\"Show Message Operation Signature\" name=\"showMessageOperationSignature\" value=\"0\"/>\r\n"
                                +*/
                "					</DiagramElementProperties>\r\n" + /*
                "					<ElementFont color=\"Cr:0,0,0,255\" name=\"Dialog\" size=\"11\" style=\"0\"/>\r\n" +
                "					<Line cap=\"0\" color=\"Cr:0,0,0,255\" transparency=\"0\" weight=\"1.0\">\r\n" +
                "						<Stroke/>\r\n" +
                "					</Line>\r\n" +
                "					<Caption height=\"15\" internalHeight=\"-2147483648\" internalWidth=\"-2147483648\" side=\"None\" visible=\"true\" width=\"50\" x=\"575\" y=\"126\"/>\r\n"
                +
                "					<Points>\r\n" +
                "						<Point x=\"521\" y=\"146\"/>\r\n" +
                "						<Point x=\"680\" y=\"146\"/>\r\n" +
                "					</Points>\r\n" + */
                "				</Connector>\r\n";
        }
    }

    public class VPShapeModel
    {
        private XClass XClass;
        public VPShapeModel(XClass myClass)
        {
            this.XClass = myClass;
        }

        public string ToString()
        {
            return
            "				<Shape height=\"184\" id=\"" + XClass.ID + "LifeLineShape\" model=\"" + XClass.ID + "LifeLine\" name=\"AppSessionLifeLine\" shapeType=\"InteractionLifeLine\" width=\"118\" x=\"458\" y=\"40\" zorder=\"7\">\r\n" +
            /*            "					<DiagramElementProperties>\r\n" +
                        "						<IntegerProperty displayName=\"ZOrder\" name=\"zOrder\" value=\"7\"/>\r\n" +
                        "						<ModelRefProperty displayName=\"Meta Model Element\" name=\"metaModelElement\">\r\n" +
                        "							<ModelRef id=\"" + XClass.ID + "LifeLine\"/>\r\n" +
                        "						</ModelRefProperty>\r\n" +
                        "						<ModelRefProperty displayName=\"Style\" name=\"style\"/>\r\n" +
                        "						<IntegerProperty displayName=\"X\" name=\"x\" value=\"458\"/>\r\n" +
                        "						<IntegerProperty displayName=\"Y\" name=\"y\" value=\"40\"/>\r\n" +
                        "						<IntegerProperty displayName=\"Width\" name=\"width\" value=\"118\"/>\r\n" +
                        "						<IntegerProperty displayName=\"Height\" name=\"height\" value=\"184\"/>\r\n" +
                        "						<ColorProperty displayName=\"Background\" name=\"background\" value=\"Cr:122,207,245,255\"/>\r\n" +
                        "						<ColorProperty displayName=\"Foreground\" name=\"foreground\" value=\"Cr:0,0,0,255\"/>\r\n" +
                        "						<StringProperty displayName=\"Creator Diagram Type\" name=\"creatorDiagramType\"/>\r\n" +
                        "						<BooleanProperty displayName=\"Selectable\" name=\"selectable\" value=\"true\"/>\r\n" +
                        "						<BooleanProperty displayName=\"Request Reset Caption\" name=\"requestResetCaption\" value=\"false\"/>\r\n" +
                        "						<BooleanProperty displayName=\"Request Reset Caption Size\" name=\"requestResetCaptionSize\" value=\"false\"/>\r\n" +
                        "						<BooleanProperty displayName=\"Request Reset Caption Fit Width\" name=\"requestResetCaptionFitWidth\" value=\"false\"/>\r\n" +
                        "						<StringArrayProperty displayName=\"Referenced By Diagram Ids\" name=\"referencedByDiagramIds\"/>\r\n" +
                        "						<StringArrayProperty displayName=\"Referenced By Model Addresses\" name=\"referencedByModelAddresses\"/>\r\n" +
                        "						<IntegerProperty displayName=\"Presentation Option\" name=\"presentationOption\" value=\"4\"/>\r\n" +
                        "						<IntegerProperty displayName=\"Primitive Shape Type\" name=\"primitiveShapeType\" value=\"0\"/>\r\n" +
                        "						<StringProperty displayName=\"Custom Text\" name=\"customText\"/>\r\n" +
                        "						<IntegerProperty displayName=\"Show Stereotype Icon Name\" name=\"showStereotypeIconName\" value=\"0\"/>\r\n" +
                        "						<IntegerProperty displayName=\"Show Allocated From\" name=\"showAllocatedFrom\" value=\"0\"/>\r\n" +
                        "						<IntegerProperty displayName=\"Show Allocated To\" name=\"showAllocatedTo\" value=\"0\"/>\r\n" +
                        "						<StringProperty displayName=\"Display Image Path\" name=\"displayImagePath\"/>\r\n" +
                        "						<StringProperty displayName=\"Display Stereotype Icon Stereotype Id\" name=\"displayStereotypeIconStereotypeId\"/>\r\n" +
                        "						<StringArrayProperty displayName=\"Hidden Stereotype Ids\" name=\"hiddenStereotypeIds\"/>\r\n" +
                        "						<BooleanProperty displayName=\"Override Appearance With Stereotype Icon\" name=\"overrideAppearanceWithStereotypeIcon\" value=\"true\"/>\r\n" +
                        "						<IntegerProperty displayName=\"Request Set Size Option\" name=\"requestSetSizeOption\" value=\"0\"/>\r\n" +
                        "						<IntegerProperty displayName=\"Parent Connector Header Length\" name=\"parentConnectorHeaderLength\" value=\"40\"/>\r\n" +
                        "						<IntegerProperty displayName=\"Parent Connector Line Length\" name=\"parentConnectorLineLength\" value=\"10\"/>\r\n" +
                        "						<BooleanProperty displayName=\"Connect To Point\" name=\"connectToPoint\" value=\"true\"/>\r\n" +
                        "						<DoubleProperty displayName=\"Parent Connector DTheta\" name=\"parentConnectorDTheta\" value=\"0.0\"/>\r\n" +
                        "						<IntegerProperty displayName=\"Connection Point Type\" name=\"connectionPointType\" value=\"2\"/>\r\n" +
                        "						<IntegerProperty displayName=\"Model Element Name Alignment\" name=\"modelElementNameAlignment\" value=\"1\"/>\r\n" +
                        "						<BooleanProperty displayName=\"Request Default Size\" name=\"requestDefaultSize\" value=\"false\"/>\r\n" +
                        "						<BooleanProperty displayName=\"Request Fit Size\" name=\"requestFitSize\" value=\"false\"/>\r\n" +
                        "						<BooleanProperty displayName=\"Request Fit Size From Center\" name=\"requestFitSizeFromCenter\" value=\"false\"/>\r\n" +
                        "						<ModelRefProperty displayName=\"Parent Frame\" name=\"parentFrame\">\r\n" +
                        "							<ModelRef id=\"A2L2_SqGAqBwAZdf\"/>\r\n" +
                        "						</ModelRefProperty>\r\n" +
                        "						<BooleanProperty displayName=\"Show Classifier\" name=\"showClassifier\" value=\"true\"/>\r\n" +
                        "					</DiagramElementProperties>\r\n" +
                        "					<ElementFont color=\"Cr:0,0,0,255\" name=\"Dialog\" size=\"11\" style=\"0\"/>\r\n" +
                        "					<Line cap=\"0\" color=\"Cr:0,0,0,255\" transparency=\"0\" weight=\"1.0\">\r\n" +
                        "						<Stroke/>\r\n" +
                        "					</Line>\r\n" +
                        "					<Caption height=\"15\" internalHeight=\"-2147483648\" internalWidth=\"-2147483648\" side=\"None\" visible=\"true\" width=\"118\" x=\"458\" y=\"40\"/>\r\n" +
                        "					<FillColor color=\"Cr:122,207,245,255\" style=\"1\" transparency=\"0\" type=\"1\"/>\r\n" + */
            "				</Shape>\r\n";
        }
    }

    public class VPLifelineModel
    {
        private XClass XClass;

        public VPLifelineModel(XClass element)
        {
            this.XClass = element;
        }

        public string ToString()
        {
            return
"				<Model composite=\"false\" considerDefaultProperties=\"false\" displayModelType=\"Lifeline\" id=\"" + XClass.ID + "LifeLine\" modelType=\"InteractionLifeLine\" name=\"" + XClass.Name + "\">\r\n" +
/*"					<ModelProperties>\r\n" +
"						<StringProperty displayName=\"Name\" name=\"name\" value=\"" + XClass.Name + "LifeLine\"/>\r\n" +
"						<StringProperty displayName=\"Model Type\" name=\"modelType\" value=\"InteractionLifeLine\"/>\r\n" +
"						<ModelsProperty displayName=\"Comments\" name=\"comments\"/>\r\n" +
"						<HTMLProperty displayName=\"Description\" name=\"documentation\" plainTextValue=\"\"/>\r\n" +
"						<ModelsProperty displayName=\"Voices\" name=\"voices\"/>\r\n" +
"						<ModelsProperty displayName=\"References\" name=\"references\"/>\r\n" +
"						<StringArrayProperty displayName=\"Referenced By Diagram Ids\" name=\"referencedByDiagramIds\"/>\r\n" +
"						<StringArrayProperty displayName=\"Referenced By Model Addresses\" name=\"referencedByModelAddresses\"/>\r\n" +
"						<StringProperty displayName=\"Transit From\" name=\"transitFrom\"/>\r\n" +
"						<StringProperty displayName=\"Transit To\" name=\"transitTo\"/>\r\n" +
"						<ModelRefProperty displayName=\"Pm Status\" name=\"pmStatus\"/>\r\n" +
"						<ModelRefProperty displayName=\"Pm Difficulty\" name=\"pmDifficulty\"/>\r\n" +
"						<ModelRefProperty displayName=\"Pm Priority\" name=\"pmPriority\"/>\r\n" +
"						<ModelRefProperty displayName=\"Pm Version\" name=\"pmVersion\"/>\r\n" +
"						<ModelRefProperty displayName=\"Pm Iteration\" name=\"pmIteration\"/>\r\n" +
"						<ModelRefProperty displayName=\"Pm Phase\" name=\"pmPhase\"/>\r\n" +
"						<ModelRefProperty displayName=\"Pm Discipline\" name=\"pmDiscipline\"/>\r\n" +
"						<StringProperty displayName=\"Pm Author\" name=\"pmAuthor\" value=\"CumpanasuF\"/>\r\n" +
"						<StringProperty displayName=\"Pm Create Date Time\" name=\"pmCreateDateTime\" value=\"1463492565317\"/>\r\n" +
"						<StringProperty displayName=\"Pm Last Modified\" name=\"pmLastModified\" value=\"1463492577709\"/>\r\n" +
"						<StringProperty displayName=\"Id\" name=\"userID\"/>\r\n" +
"						<IntegerProperty displayName=\"User IDLast Numeric Value\" name=\"userIDLastNumericValue\" value=\"0\"/>\r\n" +
"						<ModelRefsProperty displayName=\"Stereotypes\" name=\"stereotypes\"/>\r\n" +
"						<ModelProperty displayName=\"Tagged Values\" name=\"taggedValues\"/>\r\n" +
"						<ModelRefsProperty displayName=\"Sync Mapping Models\" name=\"syncMappingModels\"/>\r\n" +
"						<IntegerProperty displayName=\"Quality Score\" name=\"qualityScore\" value=\"-1\"/>\r\n" +
"						<StringProperty displayName=\"Quality Reason\" name=\"qualityReason\"/>\r\n" +
"						<ModelProperty displayName=\"Multiplicity Detail\" name=\"multiplicityDetail\"/>\r\n" +
"						<StringProperty displayName=\"Multiplicity\" name=\"multiplicity\" value=\"Unspecified\"/>\r\n" +
"						<TextModelProperty displayName=\"Base Classifier\" name=\"baseClassifier\"/>\r\n" +
"						<BooleanProperty displayName=\"Class Level Stereotype\" name=\"classLevelStereotype\" value=\"false\"/>\r\n" +
"						<BooleanProperty displayName=\"Active\" name=\"active\" value=\"false\"/>\r\n" +
"						<ModelsProperty displayName=\"Activations\" name=\"activations\">\r\n" +
"							<Model composite=\"true\" considerDefaultProperties=\"false\" displayModelType=\"Activation\" id=\"o0nvfSqGAqBwASsM\" modelType=\"Activation\" name=\"Activation\">\r\n" +
"								<ModelProperties>\r\n" +
"									<StringProperty displayName=\"Name\" name=\"name\" value=\"Activation\"/>\r\n" +
"									<StringProperty displayName=\"Model Type\" name=\"modelType\" value=\"Activation\"/>\r\n" +
"									<ModelsProperty displayName=\"Comments\" name=\"comments\"/>\r\n" +
"									<HTMLProperty displayName=\"Description\" name=\"documentation\" plainTextValue=\"\"/>\r\n" +
"									<ModelsProperty displayName=\"Voices\" name=\"voices\"/>\r\n" +
"									<ModelsProperty displayName=\"References\" name=\"references\"/>\r\n" +
"									<StringArrayProperty displayName=\"Referenced By Diagram Ids\" name=\"referencedByDiagramIds\"/>\r\n" +
"									<StringArrayProperty displayName=\"Referenced By Model Addresses\" name=\"referencedByModelAddresses\"/>\r\n" +
"									<StringProperty displayName=\"Transit From\" name=\"transitFrom\"/>\r\n" +
"									<StringProperty displayName=\"Transit To\" name=\"transitTo\"/>\r\n" +
"									<ModelRefProperty displayName=\"Pm Status\" name=\"pmStatus\"/>\r\n" +
"									<ModelRefProperty displayName=\"Pm Difficulty\" name=\"pmDifficulty\"/>\r\n" +
"									<ModelRefProperty displayName=\"Pm Priority\" name=\"pmPriority\"/>\r\n" +
"									<ModelRefProperty displayName=\"Pm Version\" name=\"pmVersion\"/>\r\n" +
"									<ModelRefProperty displayName=\"Pm Iteration\" name=\"pmIteration\"/>\r\n" +
"									<ModelRefProperty displayName=\"Pm Phase\" name=\"pmPhase\"/>\r\n" +
"									<ModelRefProperty displayName=\"Pm Discipline\" name=\"pmDiscipline\"/>\r\n" +
"									<StringProperty displayName=\"Pm Author\" name=\"pmAuthor\" value=\"CumpanasuF\"/>\r\n" +
"									<StringProperty displayName=\"Pm Create Date Time\" name=\"pmCreateDateTime\" value=\"1463492776645\"/>\r\n" +
"									<StringProperty displayName=\"Pm Last Modified\" name=\"pmLastModified\"/>\r\n" +
"									<StringProperty displayName=\"Id\" name=\"userID\"/>\r\n" +
"									<IntegerProperty displayName=\"User IDLast Numeric Value\" name=\"userIDLastNumericValue\" value=\"0\"/>\r\n" +
"									<ModelRefsProperty displayName=\"Stereotypes\" name=\"stereotypes\"/>\r\n" +
"									<ModelProperty displayName=\"Tagged Values\" name=\"taggedValues\"/>\r\n" +
"									<ModelRefsProperty displayName=\"Sync Mapping Models\" name=\"syncMappingModels\"/>\r\n" +
"									<IntegerProperty displayName=\"Quality Score\" name=\"qualityScore\" value=\"-1\"/>\r\n" +
"									<StringProperty displayName=\"Quality Reason\" name=\"qualityReason\"/>\r\n" +
"									<BooleanProperty displayName=\"Overlapping Execution Occurrence\" name=\"overlappingExecutionOccurrence\" value=\"false\"/>\r\n" +
"									<ModelRefsProperty displayName=\"Message Ends\" name=\"messageEnds\"/>\r\n" +
"									<ModelsProperty displayName=\"Activations\" name=\"activations\"/>\r\n" +
"									<DiagramElementRefProperty displayName=\"Master View\" name=\"masterView\">\r\n" +
"										<DiagramElementRef displayShapeType=\"Activation\" id=\"E0nvfSqGAqBwASsO\" model=\"o0nvfSqGAqBwASsM\" name=\"Activation\" shapeType=\"Activation\"/>\r\n" +
"									</DiagramElementRefProperty>\r\n" +
"								</ModelProperties>\r\n" +
"							</Model>\r\n" +
"							<Model composite=\"true\" considerDefaultProperties=\"false\" displayModelType=\"Activation\" id=\"U5vvfSqGAqBwASsx\" modelType=\"Activation\" name=\"Activation\">\r\n" +
"								<ModelProperties>\r\n" +
"									<StringProperty displayName=\"Name\" name=\"name\" value=\"Activation\"/>\r\n" +
"									<StringProperty displayName=\"Model Type\" name=\"modelType\" value=\"Activation\"/>\r\n" +
"									<ModelsProperty displayName=\"Comments\" name=\"comments\"/>\r\n" +
"									<HTMLProperty displayName=\"Description\" name=\"documentation\" plainTextValue=\"\"/>\r\n" +
"									<ModelsProperty displayName=\"Voices\" name=\"voices\"/>\r\n" +
"									<ModelsProperty displayName=\"References\" name=\"references\"/>\r\n" +
"									<StringArrayProperty displayName=\"Referenced By Diagram Ids\" name=\"referencedByDiagramIds\"/>\r\n" +
"									<StringArrayProperty displayName=\"Referenced By Model Addresses\" name=\"referencedByModelAddresses\"/>\r\n" +
"									<StringProperty displayName=\"Transit From\" name=\"transitFrom\"/>\r\n" +
"									<StringProperty displayName=\"Transit To\" name=\"transitTo\"/>\r\n" +
"									<ModelRefProperty displayName=\"Pm Status\" name=\"pmStatus\"/>\r\n" +
"									<ModelRefProperty displayName=\"Pm Difficulty\" name=\"pmDifficulty\"/>\r\n" +
"									<ModelRefProperty displayName=\"Pm Priority\" name=\"pmPriority\"/>\r\n" +
"									<ModelRefProperty displayName=\"Pm Version\" name=\"pmVersion\"/>\r\n" +
"									<ModelRefProperty displayName=\"Pm Iteration\" name=\"pmIteration\"/>\r\n" +
"									<ModelRefProperty displayName=\"Pm Phase\" name=\"pmPhase\"/>\r\n" +
"									<ModelRefProperty displayName=\"Pm Discipline\" name=\"pmDiscipline\"/>\r\n" +
"									<StringProperty displayName=\"Pm Author\" name=\"pmAuthor\" value=\"CumpanasuF\"/>\r\n" +
"									<StringProperty displayName=\"Pm Create Date Time\" name=\"pmCreateDateTime\" value=\"1463492794826\"/>\r\n" +
"									<StringProperty displayName=\"Pm Last Modified\" name=\"pmLastModified\"/>\r\n" +
"									<StringProperty displayName=\"Id\" name=\"userID\"/>\r\n" +
"									<IntegerProperty displayName=\"User IDLast Numeric Value\" name=\"userIDLastNumericValue\" value=\"0\"/>\r\n" +
"									<ModelRefsProperty displayName=\"Stereotypes\" name=\"stereotypes\"/>\r\n" +
"									<ModelProperty displayName=\"Tagged Values\" name=\"taggedValues\"/>\r\n" +
"									<ModelRefsProperty displayName=\"Sync Mapping Models\" name=\"syncMappingModels\"/>\r\n" +
"									<IntegerProperty displayName=\"Quality Score\" name=\"qualityScore\" value=\"-1\"/>\r\n" +
"									<StringProperty displayName=\"Quality Reason\" name=\"qualityReason\"/>\r\n" +
"									<BooleanProperty displayName=\"Overlapping Execution Occurrence\" name=\"overlappingExecutionOccurrence\" value=\"false\"/>\r\n" +
"									<ModelRefsProperty displayName=\"Message Ends\" name=\"messageEnds\"/>\r\n" +
"									<ModelsProperty displayName=\"Activations\" name=\"activations\"/>\r\n" +
"									<DiagramElementRefProperty displayName=\"Master View\" name=\"masterView\">\r\n" +
"										<DiagramElementRef displayShapeType=\"Activation\" id=\"s5vvfSqGAqBwASsz\" model=\"U5vvfSqGAqBwASsx\" name=\"Activation\" shapeType=\"Activation\"/>\r\n" +
"									</DiagramElementRefProperty>\r\n" +
"								</ModelProperties>\r\n" +
"							</Model>\r\n" +
"						</ModelsProperty>\r\n" +
"						<ModelRefsProperty displayName=\"Concurrents\" name=\"concurrents\"/>\r\n" +
"						<BooleanProperty displayName=\"Stopped\" name=\"stopped\" value=\"false\"/>\r\n" +
"						<BooleanProperty displayName=\"Multi Object\" name=\"multiObject\" value=\"false\"/>\r\n" +
"						<ModelsProperty displayName=\"Attribute Links\" name=\"attributeLinks\"/>\r\n" +
"						<BooleanProperty displayName=\"Class\" name=\"class\" value=\"false\"/>\r\n" +
"						<ModelsProperty displayName=\"State Invariants\" name=\"stateInvariants\"/>\r\n" +
"						<DiagramElementRefProperty displayName=\"Master View\" name=\"masterView\">\r\n" +
"							<DiagramElementRef displayShapeType=\"Interaction Life Line\" id=\"" + XClass.ID + "LifeLineShape\" model=\"" + XClass.ID + "LifeLine\" name=\"" + XClass.Name + "\" shapeType=\"InteractionLifeLine\"/>\r\n" +
"						</DiagramElementRefProperty>\r\n" +
"					</ModelProperties>\r\n" + /*
"					<FromEndRelationships>\r\n" +
"						<RelationshipRef from=\"" + XClass.ID + "LifeLine\" id=\"" + XMethod.ID + "\" to=\"yrSvfSqGAqBwASq.\"/>\r\n" +
"					</FromEndRelationships>\r\n" +
"					<ToEndRelationships>\r\n" +
"						<RelationshipRef from=\"yrSvfSqGAqBwASq.\" id=\"bZvvfSqGAqBwASsq\" to=\"" + XClass.ID + "LifeLine\"/>\r\n" +
"					</ToEndRelationships>\r\n" + */
"				</Model>\r\n";
        }
    }

    public class VPAssociationModel
    {
        private string ID;
        private string Name = "";
        private int ID1;
        private int ID2;

        public VPAssociationModel(int p1, int p2)
        {
            this.ID = p1 + "a" + p2;
            this.ID1 = p1;
            this.ID2 = p2;
        }

        public string ToString()
        {
            return
"						<Model composite=\"false\" considerDefaultProperties=\"false\" displayModelType=\"Association\" id=\"" + ID + "\" modelType=\"Association\" name=\"" + Name + "\">\r\n" +
"							<ModelProperties>\r\n" +
"								<StringProperty displayName=\"Name\" name=\"name\" value=\"" + Name + "\"/>\r\n" +
"								<StringProperty displayName=\"Model Type\" name=\"modelType\" value=\"Association\"/>\r\n" +
"								<ModelRefProperty displayName=\"End Relationship From Meta Model Element\" name=\"endRelationshipFromMetaModelElement\">\r\n" +
"									<ModelRef id=\"" + ID1 + "\"/>\r\n" +
"								</ModelRefProperty>\r\n" +
"								<ModelRefProperty displayName=\"End Relationship To Meta Model Element\" name=\"endRelationshipToMetaModelElement\">\r\n" +
"									<ModelRef id=\"" + ID2 + "\"/>\r\n" +
"								</ModelRefProperty>\r\n" + /*
"								<ModelsProperty displayName=\"Comments\" name=\"comments\"/>\r\n" +
"								<HTMLProperty displayName=\"Description\" name=\"documentation\" plainTextValue=\"\"/>\r\n" +
"								<ModelsProperty displayName=\"Voices\" name=\"voices\"/>\r\n" +
"								<ModelsProperty displayName=\"References\" name=\"references\"/>\r\n" +
"								<StringArrayProperty displayName=\"Referenced By Diagram Ids\" name=\"referencedByDiagramIds\"/>\r\n" +
"								<StringArrayProperty displayName=\"Referenced By Model Addresses\" name=\"referencedByModelAddresses\"/>\r\n" +
"								<StringProperty displayName=\"Transit From\" name=\"transitFrom\"/>\r\n" +
"								<StringProperty displayName=\"Transit To\" name=\"transitTo\"/>\r\n" +
"								<ModelRefProperty displayName=\"Pm Status\" name=\"pmStatus\"/>\r\n" +
"								<ModelRefProperty displayName=\"Pm Difficulty\" name=\"pmDifficulty\"/>\r\n" +
"								<ModelRefProperty displayName=\"Pm Priority\" name=\"pmPriority\"/>\r\n" +
"								<ModelRefProperty displayName=\"Pm Version\" name=\"pmVersion\"/>\r\n" +
"								<ModelRefProperty displayName=\"Pm Iteration\" name=\"pmIteration\"/>\r\n" +
"								<ModelRefProperty displayName=\"Pm Phase\" name=\"pmPhase\"/>\r\n" +
"								<ModelRefProperty displayName=\"Pm Discipline\" name=\"pmDiscipline\"/>\r\n" +
"								<StringProperty displayName=\"Pm Author\" name=\"pmAuthor\" value=\"CumpanasuF\"/>\r\n" +
"								<StringProperty displayName=\"Pm Create Date Time\" name=\"pmCreateDateTime\" value=\"1463487157697\"/>\r\n" +
"								<StringProperty displayName=\"Pm Last Modified\" name=\"pmLastModified\" value=\"1463487244518\"/>\r\n" +
"								<StringProperty displayName=\"Id\" name=\"userID\"/>\r\n" +
"								<IntegerProperty displayName=\"User IDLast Numeric Value\" name=\"userIDLastNumericValue\" value=\"0\"/>\r\n" +
"								<BooleanProperty displayName=\"Abstract\" name=\"abstract\" value=\"false\"/>\r\n" +
"								<BooleanProperty displayName=\"Leaf\" name=\"leaf\" value=\"false\"/>\r\n" +
"								<StringProperty displayName=\"Visibility\" name=\"visibility\" value=\"Unspecified\"/>\r\n" +
"								<ModelRefsProperty displayName=\"Stereotypes\" name=\"stereotypes\"/>\r\n" +
"								<ModelProperty displayName=\"Tagged Values\" name=\"taggedValues\"/>\r\n" +
"								<ModelRefsProperty displayName=\"Sync Mapping Models\" name=\"syncMappingModels\"/>\r\n" +
"								<IntegerProperty displayName=\"Quality Score\" name=\"qualityScore\" value=\"-1\"/>\r\n" +
"								<StringProperty displayName=\"Quality Reason\" name=\"qualityReason\"/>\r\n" +
"								<StringProperty displayName=\"Direction\" name=\"direction\" value=\"From-To\"/>\r\n" +
"								<BooleanProperty displayName=\"Derived\" name=\"derived\" value=\"false\"/>\r\n" +
"								<ModelProperty displayName=\"Orm Detail\" name=\"ormDetail\"/>\r\n" +
"								<ModelRefsProperty displayName=\"Item Flows\" name=\"itemFlows\"/>\r\n" +
"								<IntegerProperty displayName=\"Ordering In Profile\" name=\"orderingInProfile\" value=\"-1\"/>\r\n" + */
"								<DiagramElementRefProperty displayName=\"Master View\" name=\"masterView\">\r\n" +
"									<DiagramElementRef displayShapeType=\"Association\" id=\"" + ID + "Ref\" model=\"" + ID + "\" name=\"MyCall\" shapeType=\"Association\"/>\r\n" +
"								</DiagramElementRefProperty>\r\n" +
"							</ModelProperties>\r\n" +
"							<FromEnd>\r\n" +
"								<Model composite=\"true\" considerDefaultProperties=\"false\" displayModelType=\"Association End\" id=\"" + ID1 + "End\" modelType=\"AssociationEnd\">\r\n" +
"									<ModelProperties>\r\n" +
"										<StringProperty displayName=\"Name\" name=\"name\"/>\r\n" +
"										<StringProperty displayName=\"Model Type\" name=\"modelType\" value=\"AssociationEnd\"/>\r\n" +
"										<ModelRefProperty displayName=\"End Model Element\" name=\"EndModelElement\">\r\n" +
"											<ModelRef id=\"" + ID1 + "\"/>\r\n" +
"										</ModelRefProperty>\r\n" + /*
"										<ModelsProperty displayName=\"Comments\" name=\"comments\"/>\r\n" +
"										<HTMLProperty displayName=\"Description\" name=\"documentation\" plainTextValue=\"\"/>\r\n" +
"										<ModelsProperty displayName=\"Voices\" name=\"voices\"/>\r\n" +
"										<ModelsProperty displayName=\"References\" name=\"references\"/>\r\n" +
"										<StringArrayProperty displayName=\"Referenced By Diagram Ids\" name=\"referencedByDiagramIds\"/>\r\n" +
"										<StringArrayProperty displayName=\"Referenced By Model Addresses\" name=\"referencedByModelAddresses\"/>\r\n" +
"										<StringProperty displayName=\"Transit From\" name=\"transitFrom\"/>\r\n" +
"										<StringProperty displayName=\"Transit To\" name=\"transitTo\"/>\r\n" +
"										<ModelRefProperty displayName=\"Pm Status\" name=\"pmStatus\"/>\r\n" +
"										<ModelRefProperty displayName=\"Pm Difficulty\" name=\"pmDifficulty\"/>\r\n" +
"										<ModelRefProperty displayName=\"Pm Priority\" name=\"pmPriority\"/>\r\n" +
"										<ModelRefProperty displayName=\"Pm Version\" name=\"pmVersion\"/>\r\n" +
"										<ModelRefProperty displayName=\"Pm Iteration\" name=\"pmIteration\"/>\r\n" +
"										<ModelRefProperty displayName=\"Pm Phase\" name=\"pmPhase\"/>\r\n" +
"										<ModelRefProperty displayName=\"Pm Discipline\" name=\"pmDiscipline\"/>\r\n" +
"										<StringProperty displayName=\"Pm Author\" name=\"pmAuthor\" value=\"CumpanasuF\"/>\r\n" +
"										<StringProperty displayName=\"Pm Create Date Time\" name=\"pmCreateDateTime\" value=\"1463487157697\"/>\r\n" +
"										<StringProperty displayName=\"Pm Last Modified\" name=\"pmLastModified\"/>\r\n" +
"										<StringProperty displayName=\"Id\" name=\"userID\"/>\r\n" +
"										<IntegerProperty displayName=\"User IDLast Numeric Value\" name=\"userIDLastNumericValue\" value=\"0\"/>\r\n" +
"										<ModelRefsProperty displayName=\"Stereotypes\" name=\"stereotypes\"/>\r\n" +
"										<ModelProperty displayName=\"Tagged Values\" name=\"taggedValues\"/>\r\n" +
"										<ModelRefsProperty displayName=\"Sync Mapping Models\" name=\"syncMappingModels\"/>\r\n" +
"										<IntegerProperty displayName=\"Quality Score\" name=\"qualityScore\" value=\"-1\"/>\r\n" +
"										<StringProperty displayName=\"Quality Reason\" name=\"qualityReason\"/>\r\n" +
"										<ModelRefsProperty displayName=\"Subsetted Properties\" name=\"subsettedProperties\"/>\r\n" +
"										<ModelRefsProperty displayName=\"Redefined Properties\" name=\"redefinedProperties\"/>\r\n" +
"										<ModelRefProperty displayName=\"Representative Attribute\" name=\"representativeAttribute\"/>\r\n" +
"										<BooleanProperty displayName=\"Provide Property Getter Method\" name=\"providePropertyGetterMethod\" value=\"false\"/>\r\n" +
"										<BooleanProperty displayName=\"Provide Property Setter Method\" name=\"providePropertySetterMethod\" value=\"false\"/>\r\n" +
"										<ModelProperty displayName=\"Orm Detail\" name=\"ormDetail\"/>\r\n" +
"										<ModelProperty displayName=\"Property Strings\" name=\"propertyStrings\"/>\r\n" +
"										<ModelProperty displayName=\"Ejb Code Detail\" name=\"ejbCodeDetail\"/>\r\n" +
"										<StringProperty displayName=\"Connect To Code Model\" name=\"connectToCodeModel\" value=\"None\"/>\r\n" +
"										<ModelRefProperty displayName=\"Referenced Attribute\" name=\"referencedAttribute\"/>\r\n" +
"										<ModelProperty displayName=\"Multiplicity Detail\" name=\"multiplicityDetail\"/>\r\n" +
"										<StringProperty displayName=\"Multiplicity\" name=\"multiplicity\" value=\"Unspecified\"/>\r\n" +
"										<StringProperty displayName=\"Type Modifier\" name=\"typeModifier\" value=\"\"/>\r\n" +
"										<StringProperty displayName=\"Visibility\" name=\"visibility\" value=\"Unspecified\"/>\r\n" +
"										<StringProperty displayName=\"Aggregation Kind\" name=\"aggregationKind\" value=\"None\"/>\r\n" +
"										<StringProperty displayName=\"Navigable\" name=\"navigable\" value=\"true\"/>\r\n" + */
"										<ModelProperty displayName=\"Qualifier\" name=\"qualifier\">\r\n" +
"											<Model composite=\"true\" considerDefaultProperties=\"false\" displayModelType=\"Qualifier\" id=\"" + ID + "End\" modelType=\"Qualifier\" name=\"\">\r\n" + /*
"												<ModelProperties>\r\n" +
"													<StringProperty displayName=\"Name\" name=\"name\" value=\"\"/>\r\n" +
"													<StringProperty displayName=\"Model Type\" name=\"modelType\" value=\"Qualifier\"/>\r\n" +
"													<ModelsProperty displayName=\"Comments\" name=\"comments\"/>\r\n" +
"													<HTMLProperty displayName=\"Description\" name=\"documentation\" plainTextValue=\"\"/>\r\n" +
"													<ModelsProperty displayName=\"Voices\" name=\"voices\"/>\r\n" +
"													<ModelsProperty displayName=\"References\" name=\"references\"/>\r\n" +
"													<StringArrayProperty displayName=\"Referenced By Diagram Ids\" name=\"referencedByDiagramIds\"/>\r\n" +
"													<StringArrayProperty displayName=\"Referenced By Model Addresses\" name=\"referencedByModelAddresses\"/>\r\n" +
"													<StringProperty displayName=\"Transit From\" name=\"transitFrom\"/>\r\n" +
"													<StringProperty displayName=\"Transit To\" name=\"transitTo\"/>\r\n" +
"													<ModelRefProperty displayName=\"Pm Status\" name=\"pmStatus\"/>\r\n" +
"													<ModelRefProperty displayName=\"Pm Difficulty\" name=\"pmDifficulty\"/>\r\n" +
"													<ModelRefProperty displayName=\"Pm Priority\" name=\"pmPriority\"/>\r\n" +
"													<ModelRefProperty displayName=\"Pm Version\" name=\"pmVersion\"/>\r\n" +
"													<ModelRefProperty displayName=\"Pm Iteration\" name=\"pmIteration\"/>\r\n" +
"													<ModelRefProperty displayName=\"Pm Phase\" name=\"pmPhase\"/>\r\n" +
"													<ModelRefProperty displayName=\"Pm Discipline\" name=\"pmDiscipline\"/>\r\n" +
"													<StringProperty displayName=\"Pm Author\" name=\"pmAuthor\" value=\"CumpanasuF\"/>\r\n" +
"													<StringProperty displayName=\"Pm Create Date Time\" name=\"pmCreateDateTime\" value=\"1463487157697\"/>\r\n" +
"													<StringProperty displayName=\"Pm Last Modified\" name=\"pmLastModified\"/>\r\n" +
"													<StringProperty displayName=\"Id\" name=\"userID\"/>\r\n" +
"													<IntegerProperty displayName=\"User IDLast Numeric Value\" name=\"userIDLastNumericValue\" value=\"0\"/>\r\n" +
"													<ModelRefsProperty displayName=\"Stereotypes\" name=\"stereotypes\"/>\r\n" +
"													<ModelProperty displayName=\"Tagged Values\" name=\"taggedValues\"/>\r\n" +
"													<ModelRefsProperty displayName=\"Sync Mapping Models\" name=\"syncMappingModels\"/>\r\n" +
"													<IntegerProperty displayName=\"Quality Score\" name=\"qualityScore\" value=\"-1\"/>\r\n" +
"													<StringProperty displayName=\"Quality Reason\" name=\"qualityReason\"/>\r\n" +
"												</ModelProperties>\r\n" + */
"											</Model>\r\n" +
"										</ModelProperty>\r\n" +
"										<StringProperty displayName=\"Java Code Attribute Name\" name=\"javaCodeAttributeName\" value=\"\"/>\r\n" +
"										<BooleanProperty displayName=\"Derived\" name=\"derived\" value=\"false\"/>\r\n" +
"										<StringProperty displayName=\"Default Value\" name=\"defaultValue\"/>\r\n" +
"										<BooleanProperty displayName=\"Derived Union\" name=\"derivedUnion\" value=\"false\"/>\r\n" +
"										<BooleanProperty displayName=\"Read Only\" name=\"readOnly\" value=\"false\"/>\r\n" +
"										<BooleanProperty displayName=\"Static\" name=\"static\" value=\"false\"/>\r\n" +
"										<BooleanProperty displayName=\"Leaf\" name=\"leaf\" value=\"false\"/>\r\n" +
"										<TextModelProperty displayName=\"Type\" name=\"type\">\r\n" +
"											<ModelRef id=\"" + ID1 + "\"/>\r\n" +
"										</TextModelProperty>\r\n" +
"									</ModelProperties>\r\n" +
"								</Model>\r\n" +
"							</FromEnd>\r\n" +
"							<ToEnd>\r\n" +
"								<Model composite=\"true\" considerDefaultProperties=\"false\" displayModelType=\"Association End\" id=\"" + ID2 + "End\" modelType=\"AssociationEnd\">\r\n" +
"									<ModelProperties>\r\n" +
"										<StringProperty displayName=\"Name\" name=\"name\"/>\r\n" +
"										<StringProperty displayName=\"Model Type\" name=\"modelType\" value=\"AssociationEnd\"/>\r\n" +
"										<ModelRefProperty displayName=\"End Model Element\" name=\"EndModelElement\">\r\n" +
"											<ModelRef id=\"" + ID2 + "\"/>\r\n" +
"										</ModelRefProperty>\r\n" + /*
"										<ModelsProperty displayName=\"Comments\" name=\"comments\"/>\r\n" +
"										<HTMLProperty displayName=\"Description\" name=\"documentation\" plainTextValue=\"\"/>\r\n" +
"										<ModelsProperty displayName=\"Voices\" name=\"voices\"/>\r\n" +
"										<ModelsProperty displayName=\"References\" name=\"references\"/>\r\n" +
"										<StringArrayProperty displayName=\"Referenced By Diagram Ids\" name=\"referencedByDiagramIds\"/>\r\n" +
"										<StringArrayProperty displayName=\"Referenced By Model Addresses\" name=\"referencedByModelAddresses\"/>\r\n" +
"										<StringProperty displayName=\"Transit From\" name=\"transitFrom\"/>\r\n" +
"										<StringProperty displayName=\"Transit To\" name=\"transitTo\"/>\r\n" +
"										<ModelRefProperty displayName=\"Pm Status\" name=\"pmStatus\"/>\r\n" +
"										<ModelRefProperty displayName=\"Pm Difficulty\" name=\"pmDifficulty\"/>\r\n" +
"										<ModelRefProperty displayName=\"Pm Priority\" name=\"pmPriority\"/>\r\n" +
"										<ModelRefProperty displayName=\"Pm Version\" name=\"pmVersion\"/>\r\n" +
"										<ModelRefProperty displayName=\"Pm Iteration\" name=\"pmIteration\"/>\r\n" +
"										<ModelRefProperty displayName=\"Pm Phase\" name=\"pmPhase\"/>\r\n" +
"										<ModelRefProperty displayName=\"Pm Discipline\" name=\"pmDiscipline\"/>\r\n" +
"										<StringProperty displayName=\"Pm Author\" name=\"pmAuthor\" value=\"CumpanasuF\"/>\r\n" +
"										<StringProperty displayName=\"Pm Create Date Time\" name=\"pmCreateDateTime\" value=\"1463487157697\"/>\r\n" +
"										<StringProperty displayName=\"Pm Last Modified\" name=\"pmLastModified\"/>\r\n" +
"										<StringProperty displayName=\"Id\" name=\"userID\"/>\r\n" +
"										<IntegerProperty displayName=\"User IDLast Numeric Value\" name=\"userIDLastNumericValue\" value=\"0\"/>\r\n" +
"										<ModelRefsProperty displayName=\"Stereotypes\" name=\"stereotypes\"/>\r\n" +
"										<ModelProperty displayName=\"Tagged Values\" name=\"taggedValues\"/>\r\n" +
"										<ModelRefsProperty displayName=\"Sync Mapping Models\" name=\"syncMappingModels\"/>\r\n" +
"										<IntegerProperty displayName=\"Quality Score\" name=\"qualityScore\" value=\"-1\"/>\r\n" +
"										<StringProperty displayName=\"Quality Reason\" name=\"qualityReason\"/>\r\n" +
"										<ModelRefsProperty displayName=\"Subsetted Properties\" name=\"subsettedProperties\"/>\r\n" +
"										<ModelRefsProperty displayName=\"Redefined Properties\" name=\"redefinedProperties\"/>\r\n" +
"										<ModelRefProperty displayName=\"Representative Attribute\" name=\"representativeAttribute\"/>\r\n" +
"										<BooleanProperty displayName=\"Provide Property Getter Method\" name=\"providePropertyGetterMethod\" value=\"false\"/>\r\n" +
"										<BooleanProperty displayName=\"Provide Property Setter Method\" name=\"providePropertySetterMethod\" value=\"false\"/>\r\n" +
"										<ModelProperty displayName=\"Orm Detail\" name=\"ormDetail\"/>\r\n" +
"										<ModelProperty displayName=\"Property Strings\" name=\"propertyStrings\"/>\r\n" +
"										<ModelProperty displayName=\"Ejb Code Detail\" name=\"ejbCodeDetail\"/>\r\n" +
"										<StringProperty displayName=\"Connect To Code Model\" name=\"connectToCodeModel\" value=\"None\"/>\r\n" +
"										<ModelRefProperty displayName=\"Referenced Attribute\" name=\"referencedAttribute\"/>\r\n" +
"										<ModelProperty displayName=\"Multiplicity Detail\" name=\"multiplicityDetail\"/>\r\n" +
"										<StringProperty displayName=\"Multiplicity\" name=\"multiplicity\" value=\"Unspecified\"/>\r\n" +
"										<StringProperty displayName=\"Type Modifier\" name=\"typeModifier\" value=\"\"/>\r\n" +
"										<StringProperty displayName=\"Visibility\" name=\"visibility\" value=\"Unspecified\"/>\r\n" +
"										<StringProperty displayName=\"Aggregation Kind\" name=\"aggregationKind\" value=\"None\"/>\r\n" +
"										<StringProperty displayName=\"Navigable\" name=\"navigable\" value=\"true\"/>\r\n" + */
"										<ModelProperty displayName=\"Qualifier\" name=\"qualifier\">\r\n" +
"											<Model composite=\"true\" considerDefaultProperties=\"false\" displayModelType=\"Qualifier\" id=\"" + ID + "End\" modelType=\"Qualifier\" name=\"\">\r\n" + /*
"												<ModelProperties>\r\n" +
"													<StringProperty displayName=\"Name\" name=\"name\" value=\"\"/>\r\n" +
"													<StringProperty displayName=\"Model Type\" name=\"modelType\" value=\"Qualifier\"/>\r\n" +
"													<ModelsProperty displayName=\"Comments\" name=\"comments\"/>\r\n" +
"													<HTMLProperty displayName=\"Description\" name=\"documentation\" plainTextValue=\"\"/>\r\n" +
"													<ModelsProperty displayName=\"Voices\" name=\"voices\"/>\r\n" +
"													<ModelsProperty displayName=\"References\" name=\"references\"/>\r\n" +
"													<StringArrayProperty displayName=\"Referenced By Diagram Ids\" name=\"referencedByDiagramIds\"/>\r\n" +
"													<StringArrayProperty displayName=\"Referenced By Model Addresses\" name=\"referencedByModelAddresses\"/>\r\n" +
"													<StringProperty displayName=\"Transit From\" name=\"transitFrom\"/>\r\n" +
"													<StringProperty displayName=\"Transit To\" name=\"transitTo\"/>\r\n" +
"													<ModelRefProperty displayName=\"Pm Status\" name=\"pmStatus\"/>\r\n" +
"													<ModelRefProperty displayName=\"Pm Difficulty\" name=\"pmDifficulty\"/>\r\n" +
"													<ModelRefProperty displayName=\"Pm Priority\" name=\"pmPriority\"/>\r\n" +
"													<ModelRefProperty displayName=\"Pm Version\" name=\"pmVersion\"/>\r\n" +
"													<ModelRefProperty displayName=\"Pm Iteration\" name=\"pmIteration\"/>\r\n" +
"													<ModelRefProperty displayName=\"Pm Phase\" name=\"pmPhase\"/>\r\n" +
"													<ModelRefProperty displayName=\"Pm Discipline\" name=\"pmDiscipline\"/>\r\n" +
"													<StringProperty displayName=\"Pm Author\" name=\"pmAuthor\" value=\"CumpanasuF\"/>\r\n" +
"													<StringProperty displayName=\"Pm Create Date Time\" name=\"pmCreateDateTime\" value=\"1463487157697\"/>\r\n" +
"													<StringProperty displayName=\"Pm Last Modified\" name=\"pmLastModified\"/>\r\n" +
"													<StringProperty displayName=\"Id\" name=\"userID\"/>\r\n" +
"													<IntegerProperty displayName=\"User IDLast Numeric Value\" name=\"userIDLastNumericValue\" value=\"0\"/>\r\n" +
"													<ModelRefsProperty displayName=\"Stereotypes\" name=\"stereotypes\"/>\r\n" +
"													<ModelProperty displayName=\"Tagged Values\" name=\"taggedValues\"/>\r\n" +
"													<ModelRefsProperty displayName=\"Sync Mapping Models\" name=\"syncMappingModels\"/>\r\n" +
"													<IntegerProperty displayName=\"Quality Score\" name=\"qualityScore\" value=\"-1\"/>\r\n" +
"													<StringProperty displayName=\"Quality Reason\" name=\"qualityReason\"/>\r\n" +
"												</ModelProperties>\r\n" + */
"											</Model>\r\n" +
"										</ModelProperty>\r\n" +
"										<StringProperty displayName=\"Java Code Attribute Name\" name=\"javaCodeAttributeName\" value=\"\"/>\r\n" +
"										<BooleanProperty displayName=\"Derived\" name=\"derived\" value=\"false\"/>\r\n" +
"										<StringProperty displayName=\"Default Value\" name=\"defaultValue\"/>\r\n" +
"										<BooleanProperty displayName=\"Derived Union\" name=\"derivedUnion\" value=\"false\"/>\r\n" +
"										<BooleanProperty displayName=\"Read Only\" name=\"readOnly\" value=\"false\"/>\r\n" +
"										<BooleanProperty displayName=\"Static\" name=\"static\" value=\"false\"/>\r\n" +
"										<BooleanProperty displayName=\"Leaf\" name=\"leaf\" value=\"false\"/>\r\n" +
"										<TextModelProperty displayName=\"Type\" name=\"type\">\r\n" +
"											<ModelRef id=\"" + ID2 + "\"/>\r\n" +
"										</TextModelProperty>\r\n" +
"									</ModelProperties>\r\n" +
"								</Model>\r\n" +
"							</ToEnd>\r\n" +
"						</Model>\r\n";
        }
    }

    public class VPPackageModel
    {
        private XNamespace XNamespace;
        public VPPackageModel(XNamespace element)
        {
            this.XNamespace = element;
        }

        public string ToString()
        {
            return
"		<Model composite=\"false\" considerDefaultProperties=\"false\" displayModelType=\"Package\" id=\"" + XNamespace.ID + "\" modelType=\"Package\" name=\"" + XNamespace.Name + "\">\r\n" +
"			<ModelProperties>\r\n" +
"				<StringProperty displayName=\"Name\" name=\"name\" value=\"" + XNamespace.Name + "\"/>\r\n" +
"				<StringProperty displayName=\"Model Type\" name=\"modelType\" value=\"Package\"/>\r\n" +
"				<ModelsProperty displayName=\"Comments\" name=\"comments\"/>\r\n" +
"				<HTMLProperty displayName=\"Description\" name=\"documentation\" plainTextValue=\"\"/>\r\n" +
"				<ModelsProperty displayName=\"Voices\" name=\"voices\"/>\r\n" +
"				<ModelsProperty displayName=\"References\" name=\"references\"/>\r\n" +
"				<StringArrayProperty displayName=\"Referenced By Diagram Ids\" name=\"referencedByDiagramIds\"/>\r\n" +
"				<StringArrayProperty displayName=\"Referenced By Model Addresses\" name=\"referencedByModelAddresses\"/>\r\n" +
"				<StringProperty displayName=\"Transit From\" name=\"transitFrom\"/>\r\n" +
"				<StringProperty displayName=\"Transit To\" name=\"transitTo\"/>\r\n" +
"				<ModelRefProperty displayName=\"Pm Status\" name=\"pmStatus\"/>\r\n" +
"				<ModelRefProperty displayName=\"Pm Difficulty\" name=\"pmDifficulty\"/>\r\n" +
"				<ModelRefProperty displayName=\"Pm Priority\" name=\"pmPriority\"/>\r\n" +
"				<ModelRefProperty displayName=\"Pm Version\" name=\"pmVersion\"/>\r\n" +
"				<ModelRefProperty displayName=\"Pm Iteration\" name=\"pmIteration\"/>\r\n" +
"				<ModelRefProperty displayName=\"Pm Phase\" name=\"pmPhase\"/>\r\n" +
"				<ModelRefProperty displayName=\"Pm Discipline\" name=\"pmDiscipline\"/>\r\n" +
"				<StringProperty displayName=\"Pm Author\" name=\"pmAuthor\" value=\"CumpanasuF\"/>\r\n" +
"				<StringProperty displayName=\"Pm Create Date Time\" name=\"pmCreateDateTime\" value=\"1463485341965\"/>\r\n" +
"				<StringProperty displayName=\"Pm Last Modified\" name=\"pmLastModified\" value=\"1463485348623\"/>\r\n" +
"				<StringProperty displayName=\"Id\" name=\"userID\"/>\r\n" +
"				<IntegerProperty displayName=\"User IDLast Numeric Value\" name=\"userIDLastNumericValue\" value=\"0\"/>\r\n" +
"				<BooleanProperty displayName=\"Abstract\" name=\"abstract\" value=\"false\"/>\r\n" +
"				<BooleanProperty displayName=\"Leaf\" name=\"leaf\" value=\"false\"/>\r\n" +
"				<BooleanProperty displayName=\"Root\" name=\"root\" value=\"false\"/>\r\n" +
"				<ModelRefsProperty displayName=\"Stereotypes\" name=\"stereotypes\"/>\r\n" +
"				<ModelProperty displayName=\"Tagged Values\" name=\"taggedValues\"/>\r\n" +
"				<ModelRefsProperty displayName=\"Sync Mapping Models\" name=\"syncMappingModels\"/>\r\n" +
"				<IntegerProperty displayName=\"Quality Score\" name=\"qualityScore\" value=\"-1\"/>\r\n" +
"				<StringProperty displayName=\"Quality Reason\" name=\"qualityReason\"/>\r\n" +
"				<ModelsProperty displayName=\"Template Parameters\" name=\"templateParameters\"/>\r\n" +
"				<StringProperty displayName=\"Visibility\" name=\"visibility\" value=\"public\"/>\r\n" +
"				<StringProperty displayName=\"Default Diagram Id\" name=\"defaultDiagramId\"/>\r\n" +
"				<StringProperty displayName=\"Connect To Code Model\" name=\"connectToCodeModel\" value=\"None\"/>\r\n" +
"				<DiagramElementRefProperty displayName=\"Master View\" name=\"masterView\">\r\n" +
"					<DiagramElementRef displayShapeType=\"Package\" id=\"sIRhfSqGAqBwAQY0\" model=\"sIRhfSqGAqBwAQY1\" name=\"" + XNamespace.Name + "\" shapeType=\"Package\"/>\r\n" +
"				</DiagramElementRefProperty>\r\n" +
"			</ModelProperties>\r\n" +
"			<ChildModels>\r\n" +
"MyClasses\r\n" +
"			</ChildModels>\r\n" +
"		</Model>\r\n";
        }
    }

    public class VPClassModel
    {
        private XClass XClass;
        public VPClassModel(XClass element)
        {
            this.XClass = element;
        }

        public string ToString()
        {
            return
"				<Model composite=\"false\" considerDefaultProperties=\"false\" displayModelType=\"Class\" id=\"" + XClass.ID + "\" modelType=\"Class\" name=\"" + XClass.Name + "\">\r\n" +
"					<ModelProperties>\r\n" +
"						<StringProperty displayName=\"Name\" name=\"name\" value=\"" + XClass.Name + "\"/>\r\n" +
"						<StringProperty displayName=\"Model Type\" name=\"modelType\" value=\"Class\"/>\r\n" +
"						<ModelsProperty displayName=\"Comments\" name=\"comments\"/>\r\n" +
"						<HTMLProperty displayName=\"Description\" name=\"documentation\" plainTextValue=\"\"/>\r\n" +
"						<ModelsProperty displayName=\"Voices\" name=\"voices\"/>\r\n" +
"						<ModelsProperty displayName=\"References\" name=\"references\"/>\r\n" +
"						<StringArrayProperty displayName=\"Referenced By Diagram Ids\" name=\"referencedByDiagramIds\"/>\r\n" +
"						<StringArrayProperty displayName=\"Referenced By Model Addresses\" name=\"referencedByModelAddresses\"/>\r\n" +
"						<StringProperty displayName=\"Transit From\" name=\"transitFrom\"/>\r\n" +
"						<StringProperty displayName=\"Transit To\" name=\"transitTo\"/>\r\n" +
"						<ModelRefProperty displayName=\"Pm Status\" name=\"pmStatus\"/>\r\n" +
"						<ModelRefProperty displayName=\"Pm Difficulty\" name=\"pmDifficulty\"/>\r\n" +
"						<ModelRefProperty displayName=\"Pm Priority\" name=\"pmPriority\"/>\r\n" +
"						<ModelRefProperty displayName=\"Pm Version\" name=\"pmVersion\"/>\r\n" +
"						<ModelRefProperty displayName=\"Pm Iteration\" name=\"pmIteration\"/>\r\n" +
"						<ModelRefProperty displayName=\"Pm Phase\" name=\"pmPhase\"/>\r\n" +
"						<ModelRefProperty displayName=\"Pm Discipline\" name=\"pmDiscipline\"/>\r\n" +
"						<StringProperty displayName=\"Pm Author\" name=\"pmAuthor\" value=\"CumpanasuF\"/>\r\n" +
"						<StringProperty displayName=\"Pm Create Date Time\" name=\"pmCreateDateTime\" value=\"1463468964591\"/>\r\n" +
"						<StringProperty displayName=\"Pm Last Modified\" name=\"pmLastModified\" value=\"1463469154378\"/>\r\n" +
"						<StringProperty displayName=\"Id\" name=\"userID\"/>\r\n" +
"						<IntegerProperty displayName=\"User IDLast Numeric Value\" name=\"userIDLastNumericValue\" value=\"0\"/>\r\n" +
"						<ModelsProperty displayName=\"Orm Qualifiers\" name=\"ormQualifiers\"/>\r\n" +
"						<BooleanProperty displayName=\"Active\" name=\"active\" value=\"false\"/>\r\n" +
"						<BooleanProperty displayName=\"Business Key Mutable\" name=\"businessKeyMutable\" value=\"true\"/>\r\n" +
"						<ModelProperty displayName=\"Java Detail\" name=\"javaDetail\"/>\r\n" +
"						<ModelProperty displayName=\"Orm Detail\" name=\"ormDetail\"/>\r\n" +
"						<ModelProperty displayName=\"Dotnet Code Detail\" name=\"dotnetCodeDetail\"/>\r\n" +
"						<ModelProperty displayName=\"Action Script Code Detail\" name=\"actionScriptCodeDetail\"/>\r\n" +
"						<ModelProperty displayName=\"Ejb Code Detail\" name=\"ejbCodeDetail\"/>\r\n" +
"						<ModelProperty displayName=\"Xs Detail\" name=\"xsDetail\"/>\r\n" +
"						<ModelsProperty displayName=\"Template Parameters\" name=\"templateParameters\"/>\r\n" +
"						<StringProperty displayName=\"Connect To Code Model\" name=\"connectToCodeModel\" value=\"None\"/>\r\n" +
"						<BooleanProperty displayName=\"Business Model\" name=\"businessModel\" value=\"false\"/>\r\n" +
"						<StringProperty displayName=\"Visibility\" name=\"visibility\" value=\"public\"/>\r\n" +
"						<BooleanProperty displayName=\"Abstract\" name=\"abstract\" value=\"false\"/>\r\n" +
"						<BooleanProperty displayName=\"Leaf\" name=\"leaf\" value=\"false\"/>\r\n" +
"						<BooleanProperty displayName=\"Root\" name=\"root\" value=\"false\"/>\r\n" +
"						<ModelRefsProperty displayName=\"Stereotypes\" name=\"stereotypes\"/>\r\n" +
"						<ModelProperty displayName=\"Tagged Values\" name=\"taggedValues\"/>\r\n" +
"						<ModelRefsProperty displayName=\"Sync Mapping Models\" name=\"syncMappingModels\"/>\r\n" +
"						<IntegerProperty displayName=\"Quality Score\" name=\"qualityScore\" value=\"-1\"/>\r\n" +
"						<StringProperty displayName=\"Quality Reason\" name=\"qualityReason\"/>\r\n" +
"						<DiagramElementRefProperty displayName=\"Master View\" name=\"masterView\">\r\n" +
"							<DiagramElementRef displayShapeType=\"Class\" id=\"l1wxvSqGAqBwAQWm\" model=\"91wxvSqGAqBwAQWn\" name=\"" + XClass.Name + "\" shapeType=\"Class\"/>\r\n" +
"						</DiagramElementRefProperty>\r\n" +
"					</ModelProperties>\r\n" +
"					<ChildModels>\r\n" +
"ArgumentsAndOperators\r\n" +
"					</ChildModels>\r\n" +
"					<FromSimpleRelationships>\r\n" +
"						<RelationshipRef from=\"91wxvSqGAqBwAQWn\" id=\"NI5xvSqGAqBwAQYb\" to=\"UxGxvSqGAqBwAQXr\"/>\r\n" +
"					</FromSimpleRelationships>\r\n" +
"				</Model>\r\n";
        }
    }

    public class VPOperationModel
    {
        private XMethod method;
        public VPOperationModel(XMethod element)
        {
            this.method = element;
        }

        public string ToString()
        {
            return
                "						<Model composite=\"true\" considerDefaultProperties=\"false\" displayModelType=\"Operation\" id=\"" + method.ID + "\" modelType=\"Operation\" name=\"" + method.Name + "\">" +
                "							<ModelProperties>" +
                "								<StringProperty displayName=\"Name\" name=\"name\" value=\"" + method.Name + "\"/>" +
                "								<StringProperty displayName=\"Model Type\" name=\"modelType\" value=\"Operation\"/>" +
                "								<ModelsProperty displayName=\"Comments\" name=\"comments\"/>" +
                "								<HTMLProperty displayName=\"Description\" name=\"documentation\" plainTextValue=\"\"/>" +
                "								<ModelsProperty displayName=\"Voices\" name=\"voices\"/>" +
                "								<ModelsProperty displayName=\"References\" name=\"references\"/>" +
                "								<StringArrayProperty displayName=\"Referenced By Diagram Ids\" name=\"referencedByDiagramIds\"/>" +
                "								<StringArrayProperty displayName=\"Referenced By Model Addresses\" name=\"referencedByModelAddresses\"/>" +
                "								<StringProperty displayName=\"Transit From\" name=\"transitFrom\"/>" +
                "								<StringProperty displayName=\"Transit To\" name=\"transitTo\"/>" +
                "								<ModelRefProperty displayName=\"Pm Status\" name=\"pmStatus\"/>" +
                "								<ModelRefProperty displayName=\"Pm Difficulty\" name=\"pmDifficulty\"/>" +
                "								<ModelRefProperty displayName=\"Pm Priority\" name=\"pmPriority\"/>" +
                "								<ModelRefProperty displayName=\"Pm Version\" name=\"pmVersion\"/>" +
                "								<ModelRefProperty displayName=\"Pm Iteration\" name=\"pmIteration\"/>" +
                "								<ModelRefProperty displayName=\"Pm Phase\" name=\"pmPhase\"/>" +
                "								<ModelRefProperty displayName=\"Pm Discipline\" name=\"pmDiscipline\"/>" +
                "								<StringProperty displayName=\"Pm Author\" name=\"pmAuthor\" value=\"CumpanasuF\"/>" +
                "								<StringProperty displayName=\"Pm Create Date Time\" name=\"pmCreateDateTime\" value=\"1463468998894\"/>" +
                "								<StringProperty displayName=\"Pm Last Modified\" name=\"pmLastModified\" value=\"1463469154378\"/>" +
                "								<StringProperty displayName=\"Id\" name=\"userID\"/>" +
                "								<IntegerProperty displayName=\"User IDLast Numeric Value\" name=\"userIDLastNumericValue\" value=\"0\"/>" +
                "								<ModelsProperty displayName=\"Raised Exceptions\" name=\"raisedExceptions\"/>" +
                "								<BooleanProperty displayName=\"Static\" name=\"static\" value=\"false\"/>" +
                "								<BooleanProperty displayName=\"Leaf\" name=\"leaf\" value=\"false\"/>" +
                "								<StringProperty displayName=\"Visibility\" name=\"visibility\" value=\"public\"/>" +
                "								<ModelRefsProperty displayName=\"Stereotypes\" name=\"stereotypes\"/>" +
                "								<ModelProperty displayName=\"Tagged Values\" name=\"taggedValues\"/>" +
                "								<ModelRefsProperty displayName=\"Sync Mapping Models\" name=\"syncMappingModels\"/>" +
                "								<IntegerProperty displayName=\"Quality Score\" name=\"qualityScore\" value=\"-1\"/>" +
                "								<StringProperty displayName=\"Quality Reason\" name=\"qualityReason\"/>" +
                "								<StringArrayProperty displayName=\"Instant Reverse Sequence Diagram Ids\" name=\"instantReverseSequenceDiagramIds\"/>" +
                "								<StringProperty displayName=\"Body Condition\" name=\"bodyCondition\"/>" +
                "								<StringProperty displayName=\"Lower\" name=\"lower\"/>" +
                "								<ModelProperty displayName=\"Action Script Code Detail\" name=\"actionScriptCodeDetail\"/>" +
                "								<StringProperty displayName=\"Upper\" name=\"upper\"/>" +
                "								<StringArrayProperty displayName=\"Preconditions\" name=\"preconditions\"/>" +
                "								<StringArrayProperty displayName=\"Postconditions\" name=\"postconditions\"/>" +
                "								<ModelProperty displayName=\"Template Type Bind Info\" name=\"templateTypeBindInfo\"/>" +
                "								<ModelsProperty displayName=\"Template Parameters\" name=\"templateParameters\"/>" +
                "								<StringProperty displayName=\"Type Modifier\" name=\"typeModifier\" value=\"\"/>" +
                "								<StringProperty displayName=\"Connect To Code Model\" name=\"connectToCodeModel\" value=\"None\"/>" +
                "								<BooleanProperty displayName=\"Visible\" name=\"visible\" value=\"true\"/>" +
                "								<BooleanProperty displayName=\"Ordered\" name=\"ordered\" value=\"false\"/>" +
                "								<BooleanProperty displayName=\"Unique\" name=\"unique\" value=\"true\"/>" +
                "								<ModelRefProperty displayName=\"Classifier\" name=\"classifier\"/>" +
                "								<HTMLProperty displayName=\"Return Type Description\" name=\"returnTypeDocumentation\" plainTextValue=\"\"/>" +
                "								<TextModelProperty displayName=\"Return Type\" name=\"returnType\"/>" +
                "								<StringProperty displayName=\"Visibility\" name=\"visibility\" value=\"public\"/>" +
                "								<StringProperty displayName=\"Scope\" name=\"scope\" value=\"instance\"/>" +
                "								<ModelProperty displayName=\"Orm Detail\" name=\"ormDetail\"/>" +
                "								<ModelProperty displayName=\"Java Detail\" name=\"javaDetail\"/>" +
                "								<ModelProperty displayName=\"Ejb Code Detail\" name=\"ejbCodeDetail\"/>" +
                "								<ModelProperty displayName=\"Dotnet Code Detail\" name=\"dotnetCodeDetail\"/>" +
                "								<ModelProperty displayName=\"Cpp Detail\" name=\"cppDetail\"/>" +
                "								<BooleanProperty displayName=\"Query\" name=\"query\" value=\"false\"/>" +
                "								<BooleanProperty displayName=\"Abstract\" name=\"abstract\" value=\"false\"/>" +
                "							</ModelProperties>" +
                "						</Model>";
        }


    }
}