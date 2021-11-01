<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
	<xsl:output method="xml" indent="yes"/>

	<xsl:template match="DataBaseTable">

		<table border="1">

			<TR bgcolor="#008000">
				<TD>
					<strong>Title</strong>
				</TD>
				<TD>
					<strong>Author</strong>
				</TD>
				<TD>
					<strong>Year</strong>
				</TD>
				<TD>
					<strong>Faculty</strong>
				</TD>
				<TD>
					<strong>Department</strong>
				</TD>
				<TD>
					<strong>Pages</strong>
				</TD>
				<TD>
					<strong>Type</strong>
				</TD>
			</TR>

			<xsl:for-each select="Book">
				<xsl:sort order="ascending" select="@Year"/>

				<TR>
					<TD>
						<b>
							<xsl:value-of select="@TITLE"/>
						</b>
					</TD>
					<TD>
						<xsl:value-of select="@AUTHOR"/>
					</TD>
					<TD>
						<xsl:value-of select="@YEAR"/>
					</TD>
					<TD>
						<xsl:value-of select="@FACULTY"/>
					</TD>
					<TD>
						<xsl:value-of select="@DEPARTMENT"/>
					</TD>
					<TD>
						<xsl:value-of select="@NUMB_PAGES"/>
					</TD>
					<TD>
						<xsl:value-of select="@TYPE"/>
					</TD>
				</TR>
			</xsl:for-each>

		</table>


	</xsl:template>

</xsl:stylesheet>
